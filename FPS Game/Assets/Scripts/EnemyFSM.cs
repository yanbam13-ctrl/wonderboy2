using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    //에너미 상태 상수
    enum EnemyState
    {
        Idle,
        Move,
        Attack,
        Return,
        Damaged,
        Die
    }

    //에너미 상태 변수
    EnemyState m_State;

    //  플레이어 발견 범위
    public float findDistance; // 8f

    // 플레이어 트랜스폼
    Transform player;


    // 공격 가능 범위
    public float attackDistance; //2f

    // 이동 속도
    public float moveSpeed; //5f

    // 캐릭터 콘트롤러 컴포넌트
    CharacterController cc;

    // 누적 시간
    float currentTime = 0;

    // 공격 딜레이 시간
    float attackDelay = 2f;

    // 에너미 공격력
    public int attackPower; // 3f

    // 초기 위치 저장용 변수
    Vector3 originPos;

    // 이동 가능 범위
    public float moveDistance; // 20f

    private void Start()
    {
        //최초의 에너미 상태를 대기
        m_State = EnemyState.Idle;

        player = GameObject.Find("Player").transform;

        cc = GetComponent<CharacterController>();

        originPos = transform.position;
    }


    private void Update()
    {
        // 현재 상태를 체크해 해당 상태별로 정해진 기능을 수행
        switch (m_State)
        {
            case EnemyState.Idle:
                Idle();
                break;
            case EnemyState.Move:
                Move();
                break;
            case EnemyState.Attack:
                Attack();
                break;
            case EnemyState.Return:
                Return();
                break;
            //case EnemyState.Damaged:
            //    Damaged();
            //    break;
            //case EnemyState.Die:
            //    Die();
            //    break;
            default:
                break;
        }
    }

    void Idle()
    {
        //만일, 플레이어와의 거리가 액션 시작 범위 이내라면 Move 상태로 전환한다.
        if (Vector3.Distance(
            transform.position, player.position) < findDistance)
        {
            m_State = EnemyState.Move;
            print("상태전환 : Idle -> Move");
        }
    }

    void Move()
    {
        //만일 현재 위치가 초기위치에서 이동 가능 범위를 넘어간다면
        if (Vector3.Distance(transform.position, originPos) > moveDistance)
        {
            //현재 상태를 복귀(Return)로 전환
            m_State = EnemyState.Return;
            print("상태전환 : Move -> Return");
        }

        //만일, 플레이어와의 거리가 공격 범위 밖이라면 플레이어를 향해 이동한다.
        if (Vector3.Distance(transform.position, player.position) > attackDistance)
        {
            //이동 방향 설정
            Vector3 dir = (player.position - transform.position).normalized;

            //캐릭터 컨트롤러를 이용해 이동
            cc.Move(dir * moveSpeed * Time.deltaTime);
        }
        else
        {
            // 그렇지 않다면, 현재 상태를 공격(attack)으로 전환
            m_State = EnemyState.Attack;
            print("상태 전환: Move -> Attack");
            currentTime = attackDelay;
        }
    }

    void Attack()
    {
        //만일, 플레이어가 공격 범위 이내에 있다면 플레이어를 공격한다.
        if (Vector3.Distance(transform.position, player.position) < attackDistance)
        {
            //일정 시간마다 플레이어를 공격한다.
            currentTime += Time.deltaTime;
            if (currentTime > attackDelay)
            {
                player.GetComponent<PlayerMove>().DamageAction(attackPower);
                print("공격");
                currentTime = 0;
            }
        }
        //그렇지 않다면, 현재 상태를 이동(Move)으로 전환한다.(재추격 실시)
        else
        {
            m_State = EnemyState.Move;
            print("상태전환 : Attack -> Move");
            currentTime = 0;
        }
    }

    void Return()
    {
        //만일, 초기 위치에서의 거리가 0.1f 이상이라면 초기 위치 쪽으로 이동한다.
        if (Vector3.Distance(transform.position, originPos) > 0.1f)
        {
            Vector3 dir = (originPos - transform.position).normalized;
            cc.Move(dir * moveSpeed * Time.deltaTime);
        }
        //그렇지 않다면, 자신의 위치를 초기 위치로 조정하고 현재 상태를 대기로 전환한다.
        else
        {
            transform.position = originPos;

            //hp를 다시 회복
            //hp = maxHp;
            m_State = EnemyState.Idle;
            print("상태전환 : Return -> Idle");
        }
    }
}
