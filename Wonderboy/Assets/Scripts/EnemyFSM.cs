using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{

    //ex) Lv02(뱀)
    // 움직임 있음 _ 생성 자리 지정되어 있음
    // 플레이어 공격 3방에 죽음

    // 세번재 부터 플레이어 공격 두방에 죽음(HP가 2배로 늘어남)
    // 죽어도 일정 시간이 지나면 계속 생성됨

    //ex)
    //기본 뱀은 한방에 죽음 / 움직임 없음 / 죽으면 골드를 떨어뜨림

    //몬스터 움직임
    //ex) Lv01(뱀) 
    public bool IsMove;  // 움직임 없음 _ 자리가 지정되어 있음
    public int hp; // 플레이어 공격 한방에 죽음
    public float moveSpeed; //움직이는 몬스터의 이동속도
    public int attackPower; //몬스터의 공격력
    public float reGenratedTime; //몬스터 재생성 대기 시간

    //Vector2 startPos; // 재성성시 위치값으로 최초 위치값을 저장
    public float moveDistance; // 움직임 제한 범위
    private float leftLimit; // 왼쪽 이동제한 수치
    private float rightLimit; // 오른쪽 이동제한 수치
    private int moveDirection = -1; // 이동방향 최초값

    private float startX;
    private float[] leftDistances = { 5f, 4f, 3f, 4f, 5f }; // 왼쪽 경계 범위 변환
    private int index = 0;

    Rigidbody2D rb; // 움직임을 위해 필요한 물리엔진
    Animator anim; // 몬스터 애니메이션 

    public GameObject coin; // 죽었을때 코인 생성

    // 처음 죽을때 동전이 나옴 -> if(!dieChecks[0]) 한번도 죽은적이 없음

    // 두번째 죽을때 점수 항아리 나옴
    // -> if(dieChecks[0] && !dieChecks[1]) 한번 죽음

    // 세번째 부터 아무것도 안나옴 [이미지 변경] 
    // if(dieChecks[0] && dieChecks[1]) = 두번죽음

    private bool[] dieChecks = new bool[2];

    // 세번재 부터 플레이어 공격 두방에 죽음(HP가 2배로 늘어남)
    // hp * 2;


    // 죽어도 일정 시간이 지나면 계속 생성됨

    // 플레이어 
    PlayerMove playerMove;

    //열거형 상태 필드멤버
    enum EnemyState
    {
        Idle, // 움직임이 없는 몬스터 대기상태
        Move, // 움직임이 없는 몬스터 대기상태
        Return, // 죽으면 다시 살아나기
        Damaged, // 맞았을때
        Attack,
        Die // 죽었을때
    }

    EnemyState m_State;

    private void Awake()
    {
        //처음 X값
        startX = transform.position.x;
        rb = GetComponent<Rigidbody2D>();

        //현재 위치를 기준으로 왼쪽/오른쪽 이동 범위 계산
        leftLimit = startX - moveDistance; //7 - (5) = 2f
        rightLimit = startX; // 7 (0f)  = 7 
        // 4 ~ 7
        print($"최초 leftLimit:  {leftLimit}");


        // 최초 몬스터 상태는 Idle -> 움직이는 몬스터는 플레이어가 시야에 들어오면 움직임 시작
        m_State = EnemyState.Idle;

        anim = GetComponent<Animator>(); // 피격 애니메이션 작동에 필요

        //플레이어의 트랜스폼 컴포넌트 가져옴
        playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();


    }


    private void Update()
    {
        //현재 상태를 체크해 해당상태별로 정해진 기능을 수행
        switch (m_State)
        {
            case EnemyState.Idle:

                //움직임이 없는 몬스터 대기시 대기 애니메이션
                //움직임이 없는 몬스터는 move로 상태 초기화 시키기
                Idle();
                break;

            case EnemyState.Move:

                //움직임이 있는 몬스터는 제한 범위 내에서 움직임 (x -방향으로)
                Move();
                break;

            case EnemyState.Damaged:
                //피격 상태
                break;

            case EnemyState.Attack:
                break;
        }
    }

    //Attack (플레이어와 몬스터가 충돌했을 때)

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (!c.transform.CompareTag("Player")) return;

        playerMove.OnDamaged(attackPower, transform.position);

        m_State = EnemyState.Attack;

        StartCoroutine(EffectDelay());

    }

    IEnumerator EffectDelay()
    {
        yield return new WaitForSeconds(1f);

        //공격후 방향전환
        if (IsMove) MoveTransition();
    }

    void Die()
    {
        //진행 중인 피격 코루틴을 중지한다.
        StopAllCoroutines();

        //죽음 상태를 처리하기 위한 코루틴을 실행한다.
        StartCoroutine(DieProcess());
    }

    IEnumerator DieProcess()
    {
        //몬스터 콜라이더 컴포넌트를 비활성화시킨다.
        //col.enabled = false; // 콜라이더를 비활성화 시키면 떨어짐

        //2초 동안 기다린 후에 자기 자신을 제거
        yield return new WaitForSeconds(1f);
        print("소멸");
        
        Instantiate(coin, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void HitEnemy(int hitPower)
    {
        //사망 상태일때 함수 종료
        if (m_State == EnemyState.Die) return;

        m_State = EnemyState.Damaged;

        //플레이어의 공격력 만큼 에너미의 체력을 감소
        hp -= hitPower;
        print("Enemy HP:" + hp);

        //공격을 당하면 HP가 0이어도 피격 애니메이션 실행
        anim.SetTrigger("Damaged");

        Damaged();

        //에너미의 체력이 0보다 크면 피격 상태로 전환
        if (hp <= 0)
        {
            m_State = EnemyState.Die;
            Die();
        }

    }

    void Damaged()
    {
        //몬스터가 공격 당했을때
        //피격 상태를 처리하기 위한 코루틴을 실행
        StartCoroutine(DamageProcess());
    }

    IEnumerator DamageProcess()
    {
        if (IsMove) rb.velocity = Vector2.zero;
        //피격 모션 만큼 기다린다.
        yield return new WaitForSeconds(1.5f);

        //방향 전환
        MoveTransition();

        if (hp > 0) m_State = EnemyState.Move;
    }

    //방향 전환 메서드
    void MoveTransition()
    {
        //방향 전환
        moveDirection *= -1;

        if (moveDirection == 1) transform.rotation = Quaternion.Euler(0, 180, 0);

        else transform.rotation = Quaternion.Euler(0, 0, 0);

        if (hp > 0) m_State = EnemyState.Move;
    }


    void Move()
    {
        // 몬스터 움직이게 만들기
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

        //print($"Move() : leftLimit : {leftLimit}");

        // 왼쪽 경계 도달시 방향전환
        if (transform.position.x <= leftLimit)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            moveDirection = 1;

            //print($"transform.position.x : {transform.position.x}");
            //print($"leftLimit : {leftLimit}");

            //print($"index : {index}");
            //print($"leftDistances[index] : leftDistances[index]");
            //오른쪽으로 변경

        }

        else if (transform.position.x >= rightLimit)
        {
            //왼쪽으로 변경
            transform.rotation = Quaternion.Euler(0, 0, 0);
            moveDirection = -1;

            //왼쪽 경계 갱신
            index = (index + 1) % leftDistances.Length;
            leftLimit = startX - leftDistances[index];
        }
    }

    void Idle()
    {
        // 움직이는 몬스터는 move로 상태 변환
        if (IsMove) m_State = EnemyState.Move;
    }





}
