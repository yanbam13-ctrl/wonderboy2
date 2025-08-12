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

            //부딪힌 물체가 총알일 경우 총알 리스트에 삽입
            if (other.CompareTag("bullet"))
            {
                //playerFire 객체 얻어오기
                PlayerFire player = GameObject.Find("player").GetComponent<PlayerFire>();

                //오브젝트 풀 리스트에 총알 삽입
                player.bulletObjectPool.Add(other.gameObject);
            }
        }
        else
        {
            //그 물체를 없애고 싶다.
            Destroy(other.gameObject);
        }

    }
}
