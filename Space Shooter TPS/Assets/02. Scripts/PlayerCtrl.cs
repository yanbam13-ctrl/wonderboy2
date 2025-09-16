using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    //이동 속력 변수
    public float moveSpeed;
    //회전 속도 변수
    public float turnSpeed;

    //animation 컴포넌트를 저장할 변수
    private Animation anim;

    private void Start()
    {
        //컴포넌트를 추출해 변수에 대입
        anim = GetComponent<Animation>();

        anim.Play("Idle");
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");

        //전후 좌우 이동 방향 벡터 계산
        // forward = 0,0,1 / right = 1,0,0 -> 위아래, 좌우 의 +,- 값을 곱해준다.
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //Translate 함수를 사용한 이동 로직
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);

        //Vector3.up 축을 기준으로 trunSpeed만큼 속도로 회전
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r); //Vector3.up = 0,1,0

        //주인공 캐릭터의 애니메이션 설정
        PlayerAnim(h, v);

    }

    void PlayerAnim(float h, float v)
    {
        //키보드 입력값을 기준으로 동작할 애니메이션 수행
        if (v >= 0.1f)
        {
            anim.CrossFade("RunF", 0.25f);
        }
        else if (v <= -0.1f)
        {
            anim.CrossFade("RunB", 0.25f);
        }
        else if (h >= 0.1f)
        {
            anim.CrossFade("RunR", 0.25f);
        }
        else if (h <= -0.1f)
        {
            anim.CrossFade("RunL", 0.25f);
        }
        else {
            anim.CrossFade("Idle", 0.25f);
        }
    }
}
