using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    //���� �ȿ� �ٸ� ��ü�� ������ ��� 
    private void OnTriggerEnter(Collider other)
    {
        //���� �ε��� ��ü�� Bullet �̶��
        if (other.CompareTag("Bullet") || other.CompareTag("Enemy"))
        {
            // �ε��� ��ü�� ��Ȱ��ȭ
            other.gameObject.SetActive(false);
        }
        else
        {
            //�� ��ü�� ���ְ� �ʹ�.
            Destroy(other.gameObject);
        }

    }
}
