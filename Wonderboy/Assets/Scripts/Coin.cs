using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    int CoinValue;
    Rigidbody2D rb;

    //Animator anim;
    bool isRolling = false;
    float rollStartTime;

    private void Awake()
    {
        CoinValue = Random.Range(1, 50);
        print(CoinValue);
        //anim = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
        if (rb == null) rb = gameObject.AddComponent<Rigidbody2D>();

        // 중력 적용
        rb.gravityScale = 1.5f;

        //위로 힘을 가해 튀어오르게 (5는 힘의 크기)
        rb.AddForce(Vector2.up * 7.5f, ForceMode2D.Impulse);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //코인이 바닥에 닿는지 확인
        bool coinTouchGround = collision.gameObject.layer == LayerMask.NameToLayer("Ground");
        print(coinTouchGround);
        if (!coinTouchGround) return; // 바닥에 닿지 않았다면 리턴

        //5초뒤 코인을 바닥에 닿도록 하기 위해 현재시간 저장
        isRolling = true;


        //바닥에 닿았다면 굴러가도록 하기
        rb.velocity = new Vector2(3f, rb.velocity.y);
        rollStartTime = Time.time;

        ////바닥에 닿았다면 애니메이션 종료
        //if (anim != null) anim.SetTrigger("CoinStop");
        //print("CoinStop");
    }

    private void Update()
    {
        if (isRolling && Time.time - rollStartTime >= 5f)
        {
            //굴러가기 중지
            rb.velocity = Vector2.zero;

            //회전 제약 해제
            rb.freezeRotation = false;

            //쓰러지게 하기
            //1. 바닥에 닿지 않음
            //transform.rotation = Quaternion.Euler(80f, 0, 0);
            //transform.position = new Vector2(0f, 0f);

            //2.토크를 줘서 자연스럽게

            float dir = Random.value < 0.5f ? -1f : 1f;
            rb.AddTorque(5f * dir, ForceMode2D.Impulse);

            isRolling = false;


        }
    }


}
