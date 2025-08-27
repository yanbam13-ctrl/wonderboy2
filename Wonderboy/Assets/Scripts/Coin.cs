using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    // ===== Inspector =====
    [Header("Spin Speeds")]
    public float airSpin = 4.0f;        // 공중 시작 회전
    public float airFallTarget = 1.0f;  // 공중 감속 목표
    public float groundSpin = 0.4f;     // 지면 감속 목표
    public float airDampRate = 3f;      // 공중 회전 감속(초당)
    public float groundDampRate = 2f;   // 지면 회전 감속(초당)
    public float stopSpinDampRate = 6f; // 정지 단계 회전 감속(초당)

    [Header("Linear Move")]
    public float rollSpeed = 3f;            // 착지 직후 수평 속도
    public float linearDampRate = 0.6f;     // 굴러가는 동안 자연 감속(초당)
    public float stopLinearDampRate = 2.5f; // 정지 단계 수평 감속(초당)
    public float bounceDamping = 0.8f;      // 벽 튕김시 속도 감쇠(에너지 손실)

    [Header("Vanish")]
    public float rollDuration = 5f;         // 굴러다니는 시간
    public float fallenKeepSeconds = 2f;    // 눕고 난 뒤 유지 시간
    public Sprite fallenSprite;             // 눕힌 스프라이트(있으면 사용)
    public int coinValue;

    // ===== Internal =====
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;

    bool coinTouchGround;
    bool isRolling;
    bool isStopping;
    bool fallStarted;

    float rollStartTime;
    int rollDir = 1;          // 좌(−1)/우(+1)
    float currentSpin;        // 애니 회전 속도 (Animator 파라미터 SpinSpeed로 반영)
    float currentXSpeed;      // 실제 수평 이동 속도(물리)

    //세로 코인 / 가로 코인 콜라이더
    public CircleCollider2D standingCol; // 회전중
    public BoxCollider2D fallenCol; // 눕힌 후(처음엔 비활성)


    void Awake()
    {

        coinValue = Random.Range(1, 50);

        rb = GetComponent<Rigidbody2D>() ?? gameObject.AddComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        // 물리 기본
        rb.gravityScale = 1.5f;
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;

        // 살짝 위로 튀기기
        rb.AddForce(Vector2.up * 7.5f, ForceMode2D.Impulse);

        // 시작: 공중 빠른 회전
        currentSpin = airSpin;
        if (anim) anim.SetFloat("SpinSpeed", currentSpin);

        // 방향 랜덤(원하면 고정 유지)
        rollDir = 1;
        //rollDir = (Random.value < 0.5f) ? -1 : 1;

        if (standingCol) standingCol.enabled = true;
        if (fallenCol) fallenCol.enabled = false;

    }

    // *********** 동전 움직임
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.layer != LayerMask.NameToLayer("Ground")) return;

        // 위쪽 면과 닿았는지(벽/천장 제외)
        bool hitTop = false;
        foreach (var cp in c.contacts) if (cp.normal.y > 0.5f) { hitTop = true; break; }
        if (!hitTop) return;

        coinTouchGround = true;
        isRolling = true;
        isStopping = false;
        rollStartTime = Time.time;

        // 착지 직후: 수평 속도로 시작, 대각선 제거
        currentXSpeed = rollSpeed;
        rb.velocity = new Vector2(rollDir * currentXSpeed, 0f);
    }

    void OnCollisionStay2D(Collision2D c)
    {
        // 벽 측면과 맞닿았을 때 방향 전환(튕김)
        if (!isRolling) return;
        if (c.gameObject.layer != LayerMask.NameToLayer("Ground")) return;

        foreach (var cp in c.contacts)
        {
            // 측면 충돌: normal.x이 크면 벽
            if (Mathf.Abs(cp.normal.x) > 0.5f)
            {
                rollDir *= -1;
                currentXSpeed *= bounceDamping; // 에너지 손실
                break;
            }
        }
    }

    void Update()
    {
        // 회전 속도 감쇠(공중/지면)
        if (!coinTouchGround)
        {
            currentSpin = Mathf.MoveTowards(currentSpin, airFallTarget, airDampRate * Time.deltaTime);
        }
        else if (isRolling && !isStopping)
        {
            currentSpin = Mathf.MoveTowards(currentSpin, groundSpin, groundDampRate * Time.deltaTime);
        }

        // 정지 단계 진입 조건
        if (isRolling && (Time.time - rollStartTime >= rollDuration))
        {
            isStopping = true;
        }

        // 정지 단계: 회전 속도 0으로 수렴
        if (isStopping)
        {
            currentSpin = Mathf.MoveTowards(currentSpin, 0f, stopSpinDampRate * Time.deltaTime);
            //print("currentSpint : " + currentSpin);

            // 이동/회전 모두 충분히 느려지면 눕히기 시작
            if (!fallStarted && currentSpin <= 0.02f && Mathf.Abs(currentXSpeed) <= 0.05f)
            {
                fallStarted = true;
                isRolling = false;
                currentSpin = 0f;
                if (anim) anim.SetFloat("SpinSpeed", 0f);
                StartCoroutine(FallThenVanish());
            }
        }

        // 매 프레임 애니 파라미터 반영
        if (anim) anim.SetFloat("SpinSpeed", currentSpin);
    }

    void FixedUpdate()
    {
        if (!coinTouchGround) return;

        if (isRolling && !isStopping)
        {
            // 굴러가는 동안 천천히 감속(프릭션 느낌)
            currentXSpeed = Mathf.MoveTowards(currentXSpeed, 0f, linearDampRate * Time.fixedDeltaTime);
            rb.velocity = new Vector2(rollDir * currentXSpeed, 0f);
        }
        else if (isStopping)
        {
            // 정지 단계: 더 빠르게 감속
            currentXSpeed = Mathf.MoveTowards(currentXSpeed, 0f, stopLinearDampRate * Time.fixedDeltaTime);
            rb.velocity = new Vector2(rollDir * currentXSpeed, 0f);
        }
        else
        {
            // 안전망: 굴러가지 않으면 y는 0으로 유지
            rb.velocity = new Vector2(rb.velocity.x, 0f);
        }
    }

    IEnumerator FallThenVanish()
    {
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.bodyType = RigidbodyType2D.Kinematic;

        //물리 스텝 하나 넘긴 뒤 콜라이더 스위치(충돌 해결 도중 변경 방지)
        yield return new WaitForFixedUpdate();

        //회전 애니 끄고, 눕힌 콜라이더 켜기

        standingCol.enabled = false;
        fallenCol.enabled = true;

        if (anim) anim.enabled = false;

        Vector3 currentPos = sr.transform.position;
        currentPos.y += -0.437f;

        //yield return null;
        if (sr && fallenSprite)
        {
            sr.transform.position = currentPos;
            sr.sprite = fallenSprite;

            print("변경");
        }

        yield return null;            // 1프레임 대기(바운드 안정화)
        Physics2D.SyncTransforms();   // (선택) 물리/트랜스폼 동기화

        // ▼ 교체된 스프라이트가 ‘이미 눕혀진’ 그림이면 큰 회전 금지
        float z = 0f; // 기울이기
        float dur = 0.25f, t = 0f;
        Quaternion from = transform.rotation;
        Quaternion to = Quaternion.Euler(0, 0, z);

        while (t < dur)
        {
            t += Time.deltaTime;
            transform.rotation = Quaternion.Slerp(from, to, t / dur);
            yield return null;
        }

        SnapToGround();               // 바닥에 붙이고

        yield return new WaitForSecondsRealtime(fallenKeepSeconds);
        Destroy(gameObject);
    }


    //코인의 콜라이더 중심에서 아래로 레이캐스트해서 “바닥의 y값”을 얻고,
    //코인의 절반 높이만큼 위로 올려서 “바닥에 딱 붙인 y위치”로 스냅
    void SnapToGround()
    {
        int mask = LayerMask.GetMask("Ground");
        var col = fallenCol;
        if (!col)
        {
            print("!col : " + !col);
            return;
        }

        Vector2 origin = col.bounds.center; // 레이 시작점. col.bounds는 **월드 기준 AABB(축 정렬 바운딩 박스)**라서 스케일/오프셋 반영된 월드 좌표 중심 리턴

        print("colPosition : " + origin);
        float maxDist = 5f; // 레이를 아래로 최대 5 유닛 사용
        Debug.DrawRay(origin, Vector2.down * maxDist, Color.red, 2f); // Scene 뷰에서 빨간선으로 보이게 해서 디버그하기 쉬움(2초간 유지).

        var hit = Physics2D.Raycast(origin, Vector2.down, maxDist, mask);
        if (!hit.collider)
        {
            Debug.Log("SnapToGround: no ground hit");
            return;
        }

        float halfHeight = col.bounds.extents.y;
        float targetY = hit.point.y + halfHeight;
        Debug.Log($"SnapToGround hit {hit.collider.name}, hitY={hit.point.y}, targetY={targetY}");

        transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
    }
}