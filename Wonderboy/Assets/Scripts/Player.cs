using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // =====[ 이동/점프 튜닝 파라미터 ]=====
    [SerializeField] float moveSpeed = 5f; // 좌우 이동 속도 (수평 속도 = moveSpeed * 입력)
    [SerializeField] float jumpForce = 7f; // 점프 힘 (Impulse 모드로 한 번에 가해짐)

    // =====[ 바닥 감지용 ]=====
    [SerializeField] Transform groundCheck;          // 플레이어 발밑에 두는 빈 오브젝트(자식)
    [SerializeField] float groundRadius = 0.1f; // 발밑 감지 원의 반지름 (발바닥 크기 느낌)
    [SerializeField] LayerMask groundMask;  // "Ground" 레이어 등 바닥이 속한 레이어 선택


    private Rigidbody2D rb; // 물리 연산 담당 컴포넌트 캐시(매 프레임 GetComponent하면 느림)
    bool grounded; // 이번 FixedUpdate에서 바닥에 닿아있는지

    void Awake() { rb = GetComponent<Rigidbody2D>(); } // 시작 시 한 번만 Rigidbody2D를 찾아 캐싱


    private void Update()
    {
        // 점프 입력은 Update에서 읽는 게 좋아요 (키 입력은 프레임 기준으로 잡힘)
        // 기본 입력 설정: "Jump" = Space / "Fire1" = Ctrl or 마우스좌클릭
        // 지금 코드는 Fire1로 되어 있는데, 스페이스로 점프하려면 "Jump"로 바꾸면 됨.
        //
        // + grounded 조건을 걸어 '공중 점프 방지'

        if (Input.GetButton("Fire1") && grounded)
        {
            // 현재 상승/하강 속도를 0으로 리셋해서 '탄력 누적' 방지

            rb.velocity = new Vector2(rb.velocity.x, 0f); // 누적속도 제거

            // 위쪽으로 순간적인 힘(Impulse) 가하기
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {

        // =====[ 1) 지면 체크 ]=====
        // groundCheck.position을 중심으로 작은 원을 그려서
        // groundMask에 포함된 콜라이더와 겹치면 '바닥'으로 판단
        //
        // ※ 전제조건
        //  - groundCheck는 반드시 '플레이어의 자식'으로 발밑에 위치
        //  - 바닥 타일/플랫폼 오브젝트는 groundMask에 포함된 Layer로 설정
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        // =====[ 2) 좌우 이동 ]=====
        // "Horizontal" 축 입력(-1, 0, 1) : A/D 또는 ←/→
        float x = Input.GetAxisRaw("Horizontal");

        // y속도는 그대로 유지하고, x속도만 입력에 맞게 설정
        // 매 프레임 고정된 값을 덮어쓰기 때문에 관성 없이 '아케이드식' 이동 느낌
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
    }
}
