using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    //영역 안에 다른 물체가 감지될 경우 
    private void OnTriggerEnter(Collider other)
    {
        //만약 부딪힌 물체가 Bullet 이라면
        if (other.CompareTag("Bullet") || other.CompareTag("Enemy"))
        {
            // 부딪힌 물체를 비활성화
            other.gameObject.SetActive(false);
        }
        else
        {
            //그 물체를 없애고 싶다.
            Destroy(other.gameObject);
        }

    }
}
