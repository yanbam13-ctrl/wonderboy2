using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Player 상태
    public int hp;

    //죽었을때 
    bool isDied;
    public CinemachineVirtualCamera vcam;
    float diedStartTime = 0;

    //공격 당했을때 움직임 멈추기 위한 변수
    bool isCrash;

    //Player jump시 검의 이미지 변경을 위한 변수
    PlayerInventory pInv;  // 캐시

    //공중 공격을 위해 필요한 변수
    bool attackQueued;
    float attackQueueT;
    const float attackBuffer = 0.18f;   // 예약 유지 시간(0.15~0.2 추천)

    // =========[ 이동/점프 파라미터 ]=========
    public float moveSpeed = 5f;      // 지상에서 좌우 이동 속도
    public float airControl = 0.35f;  // 공중에서 좌우 제어 비율(지상=1, 공중은 이 값이 곱해짐)
    public float jumpHeight = 2.2f;   // "원하는 최대 점프 높이" (유닛 단위)

    // =========[ 중력/낙하 튜닝 ]=========
    public float baseGravity = 3f;        // 기본 중력 배수(Rigidbody2D.gravityScale에 적용)
    public float fallMultiplier = 2.2f;   // 떨어질 때 중력 배수(>1이면 더 빨리 떨어짐)
    public float maxFallSpeed = -20f;     // 최대 낙하 속도(너무 빨리 떨어지지 않도록 하한선)

    // =========[ 바닥 감지 ]=========
    public Transform groundCheck;     // 발밑에 둔 빈 오브젝트(플레이어의 자식)
    public float groundRadius = 0.1f; // 발밑 원 충돌 체크 반지름
    public LayerMask groundMask;      // "바닥"으로 인식할 레이어(타일/플랫폼 등)

    // =========[ 내부 상태 ]=========
    private Rigidbody2D rb;  // 물리 처리 담당 컴포넌트 캐시
    private bool grounded;   // 이번 물리 프레임에서 바닥에 닿아있는가?

    private Animator anim;

    public float moveTapBuffer = 0.12f;  // 살짝 눌러도 이 시간만큼 Move 유지
    float moveTimer;

    //공격 당했을때 상태 표시
    SpriteRenderer sr;
    public SpriteRenderer[] weponSr;



    void Awake()
    {
        PlayerPrefs.DeleteKey("DoorCount_BossRoomDoorOpen_"); //PlayerPrefs 값 초기화

        if (!PlayerPrefs.HasKey("HP"))
        {
            PlayerPrefs.SetInt("HP", 50);
        }

        hp = PlayerPrefs.GetInt("HP");
        print("hp : " + hp);

        // Rigidbody2D를 한 번만 찾아서 보관(매 프레임 GetComponent 하면 느림)
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = baseGravity; // 기본 중력 세팅

        anim = GetComponent<Animator>(); // 애니메이터 참조

        pInv = GetComponent<PlayerInventory>(); // 무기 전환 애니메이션을 위한 컴포넌트 참조

        sr = GetComponent<SpriteRenderer>(); //Player의 스프라이트 랜더러

        var t = transform.Find("SwordIdle/wepon_0");   // 부모가 비활성이어도 Find 가능
        if (t == null) { Debug.LogError("SwordIdle/wepon_0 경로를 찾지 못함"); return; }
    }


    void Update()
    {
        if (isDied) return;  // 죽으면 입력/애니메이션 로직 전부 중단

        MoveAnimAndFlip();
        JumpAnimAndJump();
        AttackAnim();
    }

    bool wasGrounded;
    void FixedUpdate()
    {
        if (isDied)
        {
            if (diedStartTime == 0)
            {
                diedStartTime = Time.time; // 죽은 시점 기록
            }

            float elapsed = Time.time - diedStartTime;

            float x = Mathf.Sin(elapsed * 10f) * 1.5f; // 진폭 1.5, 주기 빠르게

            // 죽는 동안에는 매 물리프레임 위로 속도를 '계속' 유지
            rb.velocity = new Vector2(x, 2f);
            return;
        }

        if (!isCrash) Move();
    }


    /** 죽음 **/
    public void Die()
    {
        print("Die 호출");
        if (isDied) return; // 죽은 상태면 리턴

        // 1) 플레이어 카메라 팔로우 끊기
        vcam.Follow = null;

        isDied = true; //HP가 0이 되어서 Die 메서드로 진입했다면 한번만 실행하도록
        isCrash = true;

        foreach (Transform child in transform)
        {
            print("Name: " + transform.gameObject.name);
            child.gameObject.SetActive(false);
        }

        anim.SetTrigger("IsDie");
        print("anim.SetTrigger(\"IsDie\");");

        rb.velocity = new Vector2(0, 1f);
    }

    /** 공격 **/
    void AttackAnim()
    {
        // 공격 버튼 눌렸을때 애니메이션 전환

        if (SaveInventory.SwordId < 0) return; // 검을 가지고 있지 않다면 공격버튼 작동x

        if (Input.GetButtonDown("Fire2"))
        {
            pInv?.AttackStart();
            anim.SetTrigger("IsAttack");
        }
    }

    //** 플레이어 피격 메서드 => Enemy Attack에서 호출 **
    public void OnDamaged(int damage, Vector2 targetPos)
    {
        anim.SetTrigger("Damaged");
        //print("hp : " + hp + "hp > 0 : " + (hp > 0));
        print("anim.SetTrigger(\"Damaged\");");


        //에너미의 공격력만큼 플레이어의 체력을 깎는다.
        Damaged(damage);

        gameObject.layer = 10; // PlayerDamaged 레이어로 변경해서 무적상태 만들기
        sr.color = new Color(1, 1, 1, 0.4f);
        for (int i = 0; i < weponSr.Length; i++)
        {
            weponSr[i].color = new Color(1, 1, 1, 0.4f);
        }

        print(hp);

        //충돌 처리
        int dirc = transform.position.x - targetPos.x > 0 ? 1 : -1;

        //// 기존 속도 리셋(일관성↑)
        rb.velocity = Vector2.zero;
        isCrash = true;

        // ---- 뒤로 + 위로 확실히 주기 ----
        rb.AddForce(new Vector2(dirc * 3, 7), ForceMode2D.Impulse);
        //rb.AddForce(new Vector2(dirc, 1) * 7, ForceMode2D.Impulse);

        Invoke("OffDamaged", 1);
    }
    public void Damaged(int damage)
    {
        hp -= damage;
        PlayerPrefs.SetInt("HP", hp);
        print("HP : " + hp);
    }

    void OffDamaged()
    {
        gameObject.layer = 31; // PlayerDamaged 레이어로 변경해서 무적상태 만들기
        sr.color = new Color(1, 1, 1, 1);
        for (int i = 0; i < weponSr.Length; i++)
        {
            weponSr[i].color = new Color(1, 1, 1, 1);
        }
        isCrash = false;
    }

    /** 이동 조작**/
    void Move()
    {
        // ===== 1) 바닥 감지 =====
        // groundCheck 위치를 중심으로 작은 원을 만들어 groundMask에 포함된 콜라이더와 겹치면 "바닥"으로 인식
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        // ===== 2) 좌우 이동 =====
        // Horizontal 축 입력: A/D 또는 ←/→ → -1, 0, 1 값
        float x = Input.GetAxisRaw("Horizontal");


        // 공중에서는 제어력 줄이기(airControl 배수 적용)
        float control = grounded ? 1f : airControl;

        // x속도만 입력에 맞춰 갱신(아케이드 스타일: 관성 없이 바로 덮어쓰기)
        float vx = x * moveSpeed * control;
        rb.velocity = new Vector2(vx, rb.velocity.y);

        // ===== 3) 낙하 가속/속도 제한 =====
        // 상승 중/지상: 기본 중력, 낙하 중: 더 큰 중력(빨리 떨어지게)
        rb.gravityScale = (rb.velocity.y < 0f) ? baseGravity * fallMultiplier : baseGravity;

        // 낙하 속도가 너무 빨라지지 않도록 하한 클램프
        if (rb.velocity.y < maxFallSpeed)
            rb.velocity = new Vector2(rb.velocity.x, maxFallSpeed);

        // 4) 착지 전환 감지  <<< 이 블록 추가
        if (grounded && !wasGrounded)
        {
            pInv?.SwordStateJump(false); // 착지 시: 대기 검 켜기
        }
        wasGrounded = grounded;
    }

    /*** 이동, 점프, 무기 전환 애니메이션 + 점프 ***/

    //이동 애니메이션 / 플레이어 방향전환
    void MoveAnimAndFlip()
    {
        /*------ 이동 애니메이션 / 플레이어 방향전환 */
        // 방향키(A/D, ←/→) 중 하나라도 눌렸는지 (디지털 키 입력)
        bool keyMoving =
        Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) ||
        Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

        // 아날로그/축 입력 값 (-1 ~ 1). 키보드는 보통 -1/0/1, 게임패드는 중간 값도 가능
        float axis = Input.GetAxisRaw("Horizontal");

        // 축 값이 임계치(노이즈)보다 크면 "움직임 있음"으로 간주
        bool axisMoving = Mathf.Abs(axis) > 0.05f;     // 아주 작은 떨림 무시

        // 디지털 키든, 축 값이든 둘 중 하나라도 움직임이 있으면 true
        bool movingNow = keyMoving || axisMoving;

        // ---- “살짝 눌러도” 애니메이션이 보이게 하는 버퍼 로직 ----
        // 움직임이 감지되면 타이머를 버퍼 시간으로 재충전
        if (movingNow) moveTimer = moveTapBuffer;
        // 움직임이 없으면, 시간 흐름만큼 타이머 감소
        else moveTimer -= Time.deltaTime;

        // 타이머가 0보다 남아 있으면 아직 "움직이는 중"으로 간주 (짧게 눌러도 잠깐 유지)
        bool moveState = moveTimer > 0f;

        // ← 방향 전환: x가 음수면 왼쪽을 바라보게, 양수면 오른쪽
        // 움직임 애니메이션 적용
        // x가 0보다 작다(왼쪽 입력)면 스프라이트를 좌우 반전시켜 왼쪽을 보게 함.
        // x가 0 이상(정지 또는 오른쪽 입력)이면 반전 해제 → 오른쪽 바라봄.
        if (movingNow)
        {
            if (axis > 0) transform.rotation = Quaternion.Euler(0, 0, 0);
            else transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        //if (movingNow) sr.flipX = (axis < 0);

        anim.SetBool("Move", moveState && grounded);
    }

    void JumpAnimAndJump()
    {
        /*------ 점프 / 점프 애니메이션 */
        // ★ 입력은 Update에서 읽는 게 좋음(프레임 기반).
        if (Input.GetButtonDown("Fire1") && grounded)
        {
            print("점프 실행");

            // 점프 속도 계산: v = sqrt(2 * g * h)
            // g : 실제 중력 가속도(Physics2D.gravity.y * gravityScale)
            // h : 목표 점프 높이(jumpHeight)
            float g = Mathf.Abs(Physics2D.gravity.y) * baseGravity;
            float v = Mathf.Sqrt(2f * g * jumpHeight);

            // 수직 속도 리셋(연속 점프/탄성 누적 방지)
            rb.velocity = new Vector2(rb.velocity.x, 0f);

            // 위 방향 초기 속도 부여 → 항상 같은 높이로 점프
            rb.velocity = new Vector2(rb.velocity.x, v);

            // <<< 점프 시작 알림
            pInv?.SwordStateJump(true);

        }
        anim.SetBool("IsJumping", !grounded);
    }

}