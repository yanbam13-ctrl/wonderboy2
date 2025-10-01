using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterCtrl : MonoBehaviour
{

    public enum State
    {
        IDLE,
        PATROL,
        TRACE,
        ATTACK,
        DIE
    }

    //몬스터의 현재 상태
    public State state = State.IDLE;

    // 추적 사정거리
    public float traceDist; //= 10.0f;
    public float attackDist; //= 2.0f;
    //몬스터의 사망 여부
    public bool isDie = false;

    //컴포넌트의 캐시를 처리할 변수
    private Transform monsterTr;
    private Transform playerTr;
    private NavMeshAgent agent;
    private Animator anim;

    // Animator 파라미터의 해시값 추출
    private readonly int hashTrace = Animator.StringToHash("IsTrace");
    private readonly int hashAttack = Animator.StringToHash("IsAttack");
    private readonly int hashHit = Animator.StringToHash("Hit");
    private readonly int hashPlayerDie = Animator.StringToHash("PlayerDie");
    private readonly int hashSpeed = Animator.StringToHash("Speed");
    private readonly int hashDie = Animator.StringToHash("Die");

    //혈흔 효과 프리팹
    private GameObject bloodEffect;

    //몬스터 생명 변수
    private int hp = 100;


    private void Awake()
    {
        //몬스터의 Transform 할당
        monsterTr = GetComponent<Transform>();

        //추적 대상인 Player의 Transform 할당
        playerTr = GameObject.FindWithTag("Player").GetComponent<Transform>();

        //NaveMeshAgent 컴포넌트 할당
        agent = GetComponent<NavMeshAgent>();

        //Animator 컴포넌트 할당
        anim = GetComponent<Animator>();

        //BloodSprayEffect 프리팹 로드
        bloodEffect = Resources.Load<GameObject>("GoopSprayEffect");
    }

    IEnumerator MonsterAction()
    {
        while (!isDie)
        {
            switch (state)
            {
                //IDLE 상태
                case State.IDLE:
                    //추적중지
                    agent.isStopped = true;
                    //Animator의 IsTrace 변수를 false로 설정
                    anim.SetBool(hashTrace, false);
                    break;
                //추적상태
                case State.TRACE:
                    //추적 대상의 좌표로 이동 시작
                    agent.SetDestination(playerTr.position);
                    agent.isStopped = false;
                    //Animator의 IsTrace 변수를 true로 설정
                    anim.SetBool(hashTrace, true);
                    //Animator의 IsAttack 변수를 false로 설정
                    anim.SetBool(hashAttack, false);
                    break;
                //공격상태
                case State.ATTACK:
                    //Animator의 IsAttack 변수를 true로 설정
                    anim.SetBool(hashAttack, true);
                    break;
                //사망
                case State.DIE:
                    isDie = true;
                    // 추적 정지
                    agent.isStopped = true;
                    //사망 애니메이션 실행
                    anim.SetTrigger(hashDie);
                    //몬스터의 collider 컴포넌트 비활성화
                    GetComponent<CapsuleCollider>().enabled = false;

                    //일정 시간 대기 후 오브젝트 풀링으로 환원
                    //애니메이션을 다 보기 위한 대기시간
                    yield return new WaitForSeconds(3.0f);

                    //사망 후 다시 사용할 때를 위한 hp 값을 초기화
                    hp = 100;
                    isDie = false;

                    //몬스터의 Collider 컴포넌트 활성화
                    GetComponent<CapsuleCollider>().enabled = true;
                    //몬스터 상태 초기화
                    state = State.IDLE;
                    //몬스터를 비활성화
                    gameObject.SetActive(false);
                    break;
            }
            yield return new WaitForSeconds(0.3f);
        }
    }

    IEnumerator CheckMonsterState()
    {
        while (!isDie)
        {
            //0.3초 동안 중지(대기) 하는 동안 제어권을 메시지 루프에 양보
            yield return new WaitForSeconds(0.3f);

            //몬스터의 상태가 DIE 일때 코루틴을 종료
            if (state == State.DIE) yield break;

            //몬스터와 주인공 캐릭터 사이의 거리 측정
            float distance = Vector3.Distance(playerTr.position, monsterTr.position);

            //공격 사정거리 범위로 들어왔는지 확인
            if (distance <= attackDist)
            {
                state = State.ATTACK;
            }
            else if (distance <= traceDist)
            {
                state = State.TRACE;
            }
            else
            {
                state = State.IDLE;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (state == State.DIE) return;

        Debug.Log(collision.gameObject.name);
        if (collision.collider.CompareTag("BULLET"))
        {
            //충돌한 총알을 삭제
            Destroy(collision.gameObject);
            anim.SetTrigger(hashHit);

            //총알의 충돌지점
            Vector3 pos = collision.GetContact(0).point;
            //총알의 충돌 지점의 법선 벡터
            Quaternion rot = Quaternion.LookRotation(-collision.GetContact(0).normal);
            //혈흔 효과를 생성하는 함수 호출
            ShowBloodEffect(pos, rot);

            //몬스터의 hp 차감
            hp -= 10;
            if (hp <= 0)
            {
                state = State.DIE;

                GameManager.instance.DisPlayScore(50);
                //기존에 연결된 함수 해제
                PlayerCtrl.OnPlayerDie -= this.OnPlayerDie;

                SphereCollider[] colls = GetComponentsInChildren<SphereCollider>();

                foreach (SphereCollider coll in colls)
                {
                    coll.enabled = false;
                }
            }
        }
    }

    void ShowBloodEffect(Vector3 pos, Quaternion rot)
    {
        //혈흔 효과 생성
        GameObject blood = Instantiate(bloodEffect, pos, rot, transform);
        Destroy(blood, 1.0f);
    }

    private void OnDrawGizmos()
    {
        //추적 사정거리 표시
        if (state == State.TRACE)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, traceDist);
        }

        //공격 사정거리 표시
        if (state == State.ATTACK)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackDist);
        }
    }

    void OnPlayerDie()
    {
        //몬스터의 상태를 체크하는 코루틴 함수를 모두 정지시킴
        StopAllCoroutines();

        //추적을 정지하고 애니메이션을 수행
        agent.isStopped = true;
        anim.SetFloat(hashSpeed, Random.Range(0.8f, 1.2f));
        print("Speed: " + hashSpeed);
        anim.SetTrigger(hashPlayerDie);
    }

    //스크립트가 활성화 될때마다 호출되는 함수
    private void OnEnable()
    {
        //이벤트 발생 시 수행할 함수 연결
        PlayerCtrl.OnPlayerDie += this.OnPlayerDie;

        //몬스터의 상태를 체크하는 코루틴 함수 호출
        StartCoroutine(CheckMonsterState());

        //상태에 따라 몬스터의 행동을 수행하는 코루틴 함수 호출
        StartCoroutine(MonsterAction());
    }

    //스크립트가 비활성화될 때마다 호출되는 함수
    private void OnDisable()
    {
        //기존 연결된 함수 해제
        PlayerCtrl.OnPlayerDie -= this.OnPlayerDie;
    }

}
