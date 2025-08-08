using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject normalEnemyPrefab; // �Ϲ� �� ������
    public GameObject fastEnemyPrefab; // ���� �� ������ (canShoot = false)
    public GameObject shootingEnemyPrefab; // �� ��� �� ������ (canShoot =true)
    public GameObject EnemyBulletPrefab; // �� �Ѿ� ������

    // �ּҽð�
    float minTime = 0.5f;
    // �ִ�ð�
    float maxTime = 2f;

    // ����ð�
    float currentTime;
    // �����ð�
    public float createTime = 1;
    // �� ����
    public GameObject enemyFactory;

    //������ƮǮ ũ��
    public int poolSize; // 10

    GameObject[] enemyObjectPool;

    public Transform[] spawnPoints;

    //�������� 1 x ��ġ : -3 ~ 3
    public float spawnMinX = -3f;
    public float spawnMaxX = 3f;
    public float spawnY = 6f;


    void Start()
    {
        // �¾ �� �� �����ð��� �����ϰ�
        createTime = UnityEngine.Random.Range(minTime, maxTime);

        // ������ƮǮ�� ���ʹ̸� ���� �� �ִ� ũ��� ����� �ش�.
        enemyObjectPool = new GameObject[poolSize];
        // ������Ʈ Ǯ�� ���� ���ʹ� ���� ��ŭ �ݺ��Ͽ�

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

            //���ʹ� ���忡�� ���ʹ̸� �����Ѵ�.
            //GameObject enemy = Instantiate(enemyFactory);
            GameObject enemy = Instantiate(prefabToUse);
            //��Ȱ��ȭ ��Ű��
            enemy.SetActive(false);


            Enemy enemyScript = enemy.GetComponent<Enemy>();
            if (enemyScript != null)
            {
                //�� ��� ���̸� canShoot = true, �ƴϸ� false
                enemyScript.canShoot = (prefabToUse == shootingEnemyPrefab);

                if (enemyScript.canShoot)
                {
                    enemyScript.bulletPrefab = EnemyBulletPrefab;
                }
            }
            //���ʹ̸� Ǯ�� �ְ� �ʹ�.
            enemyObjectPool[i] = enemy;

        }
    }

    void Update()
    {
        // 1. �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;
        // 2. ���� ����ð��� �����ð��� �Ǹ�
        if (currentTime > createTime)
        {
            // ���ʹ� Ǯ �ȿ� �ִ� ���ʹ̵� �߿���
            for (int i = 0; i < poolSize; i++)
            {
                //��Ȱ��ȭ�� ���ʹ̸�
                GameObject newEnemy = enemyObjectPool[i];

                if (newEnemy.activeSelf == false)
                {
                    //newEnemy.SetActive(true);

                    //x��ġ�� ����, y�� ����
                    float randomX = Random.Range(spawnMinX, spawnMaxX);
                    Vector3 spawnPos = new Vector3(randomX, spawnY, 0f);

                    //�������� �ε��� ����
                    int index = Random.Range(0, spawnPoints.Length);

                    newEnemy.transform.position = spawnPos;
                    newEnemy.SetActive(true);
                    //newEnemy.transform.position = spawnPoints[index].position;
                    break;
                }
            }

            //// 3. �� ���忡�� ���� �����ؼ�
            //GameObject enemy = Instantiate(enemyFactory);
            //// �� ��ġ�� ���� ���� �ʹ�.
            //enemy.transform.position = transform.position;
            //// ����ð��� 0���� �ʱ�ȭ
            currentTime = 0;

            // ���� ������ �� �� �����ð��� �ٽ� �����ϰ� �ʹ�.
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }
    }
}
