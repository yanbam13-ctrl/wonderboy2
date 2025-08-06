using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // 최소시간
    float minTime = 0.5f;
    // 최대시간
    float maxTime = 2f;

    // 현재시간
    float currentTime;
    // 일정시간
    public float createTime = 1;
    // 적 공장
    public GameObject enemyFactory;

    //오브젝트풀 크기
    public int poolSize; // 10

    GameObject[] enemyObjectPool;

    public Transform[] spawnPoints;


    void Start()
    {
        // 태어날 때 적 생성시간을 설정하고
        createTime = UnityEngine.Random.Range(minTime, maxTime);

        // 오브젝트풀을 에너미를 담을 수 있는 크기로 만들어 준다.
        enemyObjectPool = new GameObject[poolSize];
        // 오브젝트 풀에 넣을 에너미 개수 만큼 반복하여

        for (int i = 0; i < poolSize; i++)
        {
            //에너미 공장에서 에너미를 생성한다.
            GameObject enemy = Instantiate(enemyFactory);

            //에너미를 풀에 넣고 싶다.
            enemyObjectPool[i] = enemy;

            //비활성화 시키자
            enemy.SetActive(false);
        }
    }

    void Update()
    {
        // 1. 시간이 흐르다가
        currentTime += Time.deltaTime;
        // 2. 만약 현재시간이 일정시간이 되면
        if (currentTime > createTime)
        {
            // 에너미 풀 안에 있는 에너미들 중에서
            for (int i = 0; i < poolSize; i++)
            {
                //비활성화된 에너미를
                GameObject newEnemy = enemyObjectPool[i];

                if (newEnemy.activeSelf == false)
                {
                    newEnemy.SetActive(true);

                    //랜덤으로 인덱스 선택
                    int index = Random.Range(0, spawnPoints.Length);

                    newEnemy.transform.position = spawnPoints[index].position;
                    break;
                }
            }

            //// 3. 적 공장에서 적을 생성해서
            //GameObject enemy = Instantiate(enemyFactory);
            //// 내 위치에 갖다 놓고 싶다.
            //enemy.transform.position = transform.position;
            //// 현재시간을 0으로 초기화
            currentTime = 0;

            // 적을 생성한 후 적 생성시간을 다시 설정하고 싶다.
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
