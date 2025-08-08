using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;

    // ������ ���������� ���� Start�� Update���� ���
    Vector3 dir;

    //���� ���� �ּ�(�ܺο��� ���� �־��ش�.)
    public GameObject explosionFactory;

    public bool canShoot = false;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float shootInterval = 2f;
    private float shootTimer = 0f;

    public Score sc;
    private int enemyScore;

    void Start()
    {
        // �÷��̾ ã�Ƽ� target���� �ϰ�ʹ�.
        GameObject target = GameObject.Find("Player");

        // 0���� 9(10-1) ���� ���߿� �ϳ��� �������� �����ͼ�
        // ���� 3���� ������ �÷��̾����
        if (target != null)
        {
            int randValue = UnityEngine.Random.Range(0, 10);

            if (randValue < 3)
            {
                // ������ ���ϰ�ʹ�. target - me
                dir = target.transform.position - transform.position;
                // ������ ũ�⸦ 1�� �ϰ� �ʹ�.
                dir.Normalize();
            }
            else
            {
                // �׷��� ������ �Ʒ��������� ���ϰ� �ʹ�.
                dir = Vector3.down;
            }

        }

    }

    void Update()
    {
        // 1. ������ ���Ѵ�.
        //Vector3 dir = Vector3.down;
        // 2. �̵��ϰ� �ʹ�. ���� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;

        if (canShoot)
        {
            shootTimer += Time.deltaTime;
            if (shootTimer >= shootInterval)
            {
                Shoot();
                shootTimer = 0f;
            }
        }

    }

    void Shoot()
    {
        if (bulletPrefab != null && firePoint != null)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    //1. ���� �ٸ� ��ü�� �浹 �����ϱ�.
    private void OnCollisionEnter(Collision other)
    {/*
        // ���ʹ̸� ���� ������ ���� ���� ǥ���ϰ� �ʹ�.
        // 1. ������ ScoreManager ��ü�� ã�ƿ���
        GameObject smObject = GameObject.Find("ScoreManager");
        // 2.ScoreManager ���ӿ�����Ʈ���� ��� �´�
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        // 3. ScoreManager �� Get/Set �Լ��� ����
        sm.SetScore(sm.GetScore() + 1);

        */
        

        
        if (sc != null)
        {
            enemyScore = sc.score;
            Debug.Log(enemyScore);
        }

        //ScoreManager.Instance.SetScore(ScoreManager.Instance.GetScore() + enemyScore);
        ScoreManager.Instance.SetScore(enemyScore);


        //2.���� ȿ�� ���忡�� ���� ȿ���� �ϳ� ������ �Ѵ�.
        GameObject explosion = Instantiate(explosionFactory);
        //3.���� ȿ���� �߻�(��ġ) ��Ű�� �ʹ�.
        explosion.transform.position = transform.position;

        //���� �ε��� ��ü�� Bullet �̶��
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("Enemy"))
        {
            // �ε��� ��ü�� ��Ȱ��ȭ
            other.gameObject.SetActive(false);
        }
        else
        {
            //�� ��ü�� ���ְ� �ʹ�.
            Destroy(other.gameObject);
        }

        // ������
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
