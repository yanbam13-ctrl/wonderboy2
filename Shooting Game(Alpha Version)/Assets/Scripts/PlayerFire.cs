using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //�Ѿ� ������ ����
    public GameObject bulletFactory; // ť�� ������Ʈ ����

    //źâ�� ���� �Ѿ� ����
    public int poolSize; // 10

    //������ƮǮ �迭
    GameObject[] bulletObjectPool;

    //�ѱ�
    public GameObject firePosition;

    private void Start()
    {
        //źâ�� ũ�⸦ �Ѿ��� ���� �� �ִ� ũ��� ����� �ش�.
        bulletObjectPool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {

            //�Ѿ� ���忡�� �Ѿ��� �����Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);

            //�Ѿ��� ������Ʈ Ǯ�� �ִ´�.
            bulletObjectPool[i] = bullet;
            bullet.SetActive(false);
        }
    }

    void Update()
    {
        //��ǥ: ����ڰ� �߻� ��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
        //���� : 1.����ڰ� �߻� ��ư�� ������
        // - ���� ����ڰ� �߻� ��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            /*
            //2.�Ѿ� ���忡�� �Ѿ��� �����.
            GameObject bullet = Instantiate(bulletFactory);
            */

            for (int i = 0; i < poolSize; i++)
            {

                //��Ȱ��ȭ �� �Ѿ���
                GameObject bullet = bulletObjectPool[i];
                if (bullet.activeSelf == false)
                {
                    //�߻� (Ȱ��ȭ ��Ų��.)
                    bullet.SetActive(true);
                    //�Ѿ��� ��ġ��Ų��. // //3.�Ѿ��� �߻��Ѵ�.(�Ѿ��� �ѱ���ġ�� ������ ����)
                    bullet.transform.position = firePosition.transform.position;
                    //�Ѿ��� �߻��߱� ������ ��Ȱ��ȭ �Ѿ� �˻��� �ߴ�.
                    break;
                }

            }

        }
    }
}
