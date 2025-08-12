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
    public float createTime;
    // 적 공장
    public GameObject[] enemyFactory;

    // 오브젝트풀 크기
    public int poolSize;    // 10
    // 오브젝트풀 배열
    public List<GameObject>[] enemyObjectPool;

    void Start()
    {
        // 태어날 때 적 생성시간을 설정하고
        createTime = UnityEngine.Random.Range(minTime, maxTime);

        enemyObjectPool = new List<GameObject>[3];
        // 오브젝트 풀에 넣을 에너미 개수 만큼 반복하여
        for (int i = 0; i < enemyObjectPool.Length; i++)
        {
            enemyObjectPool[i] = new List<GameObject>();
            for (int j = 0; j < poolSize; j++)
            {
                // 에너미 공장에서 에너미를 생성한다.
                GameObject enemy = Instantiate(enemyFactory[i]);
                // 에너미를 오브젝트풀에 넣고 싶다.
                enemyObjectPool[i].Add(enemy);
                // 비활성화 시키자
                enemy.SetActive(false);
            }
        }
    }

    void Update()
    {
        // 1. 시간이 흐르다가
        currentTime += Time.deltaTime;
        // 2. 만약 현재시간이 일정시간이 되면
        if (currentTime > createTime)
        {
            int enemyNum = Random.Range(0, enemyFactory.Length);
            List<GameObject> pool = enemyObjectPool[enemyNum];
            // 에너미풀 안에 있는 에너미들 중에서
            if (pool.Count > 0)
            {
                // 비활성화된 에너미를
                GameObject enemy = pool[0];
                // 에너미를 활성화
                enemy.SetActive(true);
                // 랜덤으로 x축 위치값 구하기
                float xPos = Random.Range(-3f, 3f);
                // 에너미 위치 시키기
                enemy.transform.position = new Vector3(xPos, 6f, 0f);

                // 오브젝트 풀에서 에너미 제거
                pool.RemoveAt(0);
            }
            // 현재시간을 0으로 초기화
            currentTime = 0;
            // 적을 생성한 후 적 생성시간을 다시 설정하고 싶다.
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
