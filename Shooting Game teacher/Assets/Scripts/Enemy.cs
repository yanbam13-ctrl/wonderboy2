using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyIdx;

    //필요속성 : 이동속도
    public float speed = 5;

    // 점수
    public int score;

    // 방향을 전역변수로 만들어서 Start와 Update에서 사용
    Vector3 dir;

    //폭발 공장 주소(외부에서 값을 넣어준다.)
    public GameObject explosionFactory;

    private void OnEnable()
    {
        // 0부터 9(10-1) 까지 값중에 하나를 랜덤으로 가져와서
        int randValue = UnityEngine.Random.Range(0, 10);
        // 만약 3보다 작으면 플레이어방향
        if (randValue < 3)
        {
            // 플레이어를 찾아서 target으로 하고싶다.
            GameObject target = GameObject.Find("Player");
            // 방향을 구하고싶다. target - me
            dir = target.transform.position - transform.position;
            // 방향의 크기를 1로 하고 싶다.
            dir.Normalize();
        }
        // 그렇지 않으면 아래방향으로 정하고 싶다.
        else
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        // 1. 방향을 구한다.
        //Vector3 dir = Vector3.down;
        // 2. 이동하고 싶다. 공식 P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    //1. 적이 다른 물체와 충돌 했으니까.
    private void OnCollisionEnter(Collision other)
    {
        // 에너미를 잡을 때마다 현재 점수 표시하고 싶다.
        /*
        // 1. 씬에서 ScoreManager 객체를 찾아오자
        GameObject smObject = GameObject.Find("ScoreManager");
        // 2.ScoreManager 게임오브젝트에서 얻어 온다
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        // 3. ScoreManager 의 Get/Set 함수로 수정
        sm.SetScore(sm.GetScore() + 1);
        */
        ScoreManager.Instance.SetScore(ScoreManager.Instance.GetScore() + score);

        //2.폭발 효과 공장에서 폭발 효과를 하나 만들어야 한다.
        GameObject explosion = Instantiate(explosionFactory);
        //3.폭발 효과를 발생(위치) 시키고 싶다.
        explosion.transform.position = transform.position;
        // 만약 부딪힌 물체가 Bullet 이라면
        if (other.gameObject.CompareTag("Bullet"))
        {
            // 부딪힌 물체를 비활성화
            other.gameObject.SetActive(false);

            // PlayerFire 객체 얻어오기
            PlayerFire player =
                GameObject.Find("Player").GetComponent<PlayerFire>();
            // 리스트에 총알 삽입
            player.bulletObjectPool.Add(other.gameObject);
        }
        else if (other.gameObject.CompareTag("BigBullet"))
        {
            // 큰총알인 경우 사라지지 않게 처리
        }
        else
        {
            // 너죽고
            Destroy(other.gameObject);
        }
        // 나죽자
        gameObject.SetActive(false);
        // EnemyManager 객체 얻어오기
        EnemyManager em =
            GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
        // 오브젝트 풀 리스트에 에너미 삽입
        em.enemyObjectPool[enemyIdx].Add(other.gameObject);
    }
}
