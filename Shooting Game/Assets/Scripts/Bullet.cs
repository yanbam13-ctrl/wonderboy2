using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;

    void Update()
    {
        // 1. ������ ���Ѵ�.
        Vector3 dir = Vector3.up;
        // 2. �̵��ϰ� �ʹ�. ���� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
