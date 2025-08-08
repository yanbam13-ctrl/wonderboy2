using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject normalEnemyPrefab; // 일반 적 프리팹
    public GameObject fastEnemyPrefab; // 빠른 적 프리팹 (canShoot = false)
    public GameObject shootingEnemyPrefab; // 총 쏘는 적 프리팹 (canShoot =true)
    public GameObject EnemyBulletPrefab; // 적 총알 프리팹

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

    //연습문제 1 x 위치 : -3 ~ 3
    public float spawnMinX = -3f;
    public float spawnMaxX = 3f;
    public float spawnY = 6f;


    void Start()
    {
        // 태어날 때 적 생성시간을 설정하고
        createTime = UnityEngine.Random.Range(minTime, maxTime);

        // 오브젝트풀을 에너미를 담을 수 있는 크기로 만들어 준다.
        enemyObjectPool = new GameObject[poolSize];
        // 오브젝트 풀에 넣을 에너미 개수 만큼 반복하여

        for (int i = 0; i < poolSize; i++)
        {

            int rand = Random.Range(0, 3);
            GameObject prefabToUse = null;

            if (rand == 0)
            {
                prefabToUse = normalEnemyPrefab;
            }
            else if (rand == 1)
            {
                prefabToUse = fastEnemyPrefab;
            }
            else
            {
                prefabToUse = shootingEnemyPrefab;

            }

            //에너미 공장에서 에너미를 생성한다.
            //GameObject enemy = Instantiate(enemyFactory);
            GameObject enemy = Instantiate(prefabToUse);
            //비활성화 시키자
            enemy.SetActive(false);


            Enemy enemyScript = enemy.GetComponent<Enemy>();
            if (enemyScript != null)
            {
                //총 쏘는 적이면 canShoot = true, 아니면 false
                enemyScript.canShoot = (prefabToUse == shootingEnemyPrefab);

                if (enemyScript.canShoot)
                {
                    enemyScript.bulletPrefab = EnemyBulletPrefab;
                }
            }
            //에너미를 풀에 넣고 싶다.
            enemyObjectPool[i] = enemy;

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
                    //newEnemy.SetActive(true);

                    //x위치는 랜덤, y는 고정
                    float randomX = Random.Range(spawnMinX, spawnMaxX);
                    Vector3 spawnPos = new Vector3(randomX, spawnY, 0f);

                    //랜덤으로 인덱스 선택
                    int index = Random.Range(0, spawnPoints.Length);

                    newEnemy.transform.position = spawnPos;
                    newEnemy.SetActive(true);
                    //newEnemy.transform.position = spawnPoints[index].position;
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
