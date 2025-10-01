using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    //이동 속력 변수
    public float moveSpeed;
    //회전 속도 변수
    public float turnSpeed;

    //animation 컴포넌트를 저장할 변수
    private Animation anim;

    //컴포넌트를 캐시 처리할 변수
    private Transform tr;

    //초기 생명 값
    private readonly float initHP = 100.0f;

    //현재 생명값
    public float currHp;

    //Hpbar 연결할 변수
    private Image hpBar;

    //델리게이트 선언
    public delegate void PlayerDieHandler();

    //이벤트 선언
    public static event PlayerDieHandler OnPlayerDie;


    IEnumerator Start()
    {
        //Hpbar 연결
        hpBar = GameObject.FindGameObjectWithTag("HP_BAR")?.GetComponent<Image>();

        //HP 초기화
        currHp = initHP;
        DisplayHealth();

        //컴포넌트를 추출해 변수에 대입
        tr = GetComponent<Transform>();
        anim = GetComponent<Animation>();

        anim.Play("Idle");

        turnSpeed = 0.0f;

        yield return new WaitForSeconds(0.3f);
        turnSpeed = 80.0f;
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
        else
        {
            anim.CrossFade("Idle", 0.25f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //충돌한 Collider가 몬스터의 PUNCH이면 Player의 HP차감
        if (currHp >= 0.0f && other.CompareTag("PUNCH"))
        {
            currHp -= 10.0f;
            Debug.Log($"Player hp = {currHp / initHP}");
            DisplayHealth();

            //Player의 생명이 0이하이면 사망처리
            if (currHp <= 0.0f)
            {
                PlayerDie();
            }
        }
    }

    //Player의 사망처리
    void PlayerDie()
    {
        Debug.Log("Player Die!");

        ////MONSTER 태그를 가진 모든 게임오브젝트를 찾아옴
        //GameObject[] monsters = GameObject.FindGameObjectsWithTag("MONSTER");

        ////모든 몬스터의 OnPlayerDie 함수를 순차적으로 호출
        //foreach (GameObject monster in monsters)
        //{
        //    monster.SendMessage("OnPlayerDie", SendMessageOptions.DontRequireReceiver);
        //}

        //주인공 사망 이벤트 호출(발생)
        OnPlayerDie();

        //GameManager 스크립트의 IsGameOver 프로퍼티 값을 변경
        //GameObject.Find("GameMgr").GetComponent<GameManager>().IsGameOver = true;

        //싱글턴으로 변경
        GameManager.instance.IsGameOver = true;
    }


    void DisplayHealth()
    {
        hpBar.fillAmount = currHp / initHP;
    }


//#if UNITY_EDITOR
//    private void OnGUI()
//    {
//        GUI.Label(new Rect(10, 10, 400, 100), "SpaceShooter");
//        if (GUI.Button(new Rect(10, 60, 200, 60), "START"))
//        {
//            Debug.Log("START button clicked");
//        }
//    }
//#endif

}
