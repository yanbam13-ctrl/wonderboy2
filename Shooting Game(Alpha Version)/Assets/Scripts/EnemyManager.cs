using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
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


    void Start()
    {
        // �¾ �� �� �����ð��� �����ϰ�
        createTime = UnityEngine.Random.Range(minTime, maxTime);

        // ������ƮǮ�� ���ʹ̸� ���� �� �ִ� ũ��� ����� �ش�.
        enemyObjectPool = new GameObject[poolSize];
        // ������Ʈ Ǯ�� ���� ���ʹ� ���� ��ŭ �ݺ��Ͽ�

        for (int i = 0; i < poolSize; i++)
        {
            //���ʹ� ���忡�� ���ʹ̸� �����Ѵ�.
            GameObject enemy = Instantiate(enemyFactory);

            //���ʹ̸� Ǯ�� �ְ� �ʹ�.
            enemyObjectPool[i] = enemy;

            //��Ȱ��ȭ ��Ű��
            enemy.SetActive(false);
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
                    newEnemy.SetActive(true);

                    //�������� �ε��� ����
                    int index = Random.Range(0, spawnPoints.Length);

                    newEnemy.transform.position = spawnPoints[index].position;
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
