using System.Collections;
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

    // ===== Internal =====
    int coinValue;
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
    }

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

        yield return null;            // 1프레임 대기(바운드 안정화)
        //SnapToGround();               // 먼저 바닥에 붙이고

        if (anim) anim.enabled = false;
        if (sr && fallenSprite) sr.sprite = fallenSprite;

        // ▼ 교체된 스프라이트가 ‘이미 눕혀진’ 그림이면 큰 회전 금지
        float z = 90.0f; // 살짝만 기울이기
        float dur = 0.25f, t = 0f;
        Quaternion from = transform.rotation;
        Quaternion to = Quaternion.Euler(0, 0, z);

        while (t < dur)
        {
            t += Time.deltaTime;
            transform.rotation = Quaternion.Slerp(from, to, t / dur);
            yield return null;
        }
        Vector2 currentPosition = transform.position;
        currentPosition.y = -2.93f;

        transform.position = currentPosition;

        print(currentPosition);

        yield return new WaitForSecondsRealtime(fallenKeepSeconds);
        Destroy(gameObject);
    }

    void SnapToGround()
    {
        int mask = LayerMask.GetMask("Ground");
        var col = GetComponent<Collider2D>();
        if (!col) return;

        Vector2 origin = col.bounds.center;
        print("colPosition : " + origin);
        float maxDist = 5f;
        Debug.DrawRay(origin, Vector2.down * maxDist, Color.red, 2f);

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