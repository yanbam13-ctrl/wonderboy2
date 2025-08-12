using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    //영역 안에 다른 물체가 감지될 경우 
    private void OnTriggerEnter(Collider other)
    {
        // 부딪힌 물체가 총알일 경우 총알 리스트에 삽입
        if (other.CompareTag("Bullet"))
        {
            // 부딪힌 물체를 비활성화
            other.gameObject.SetActive(false);
            // PlayerFire 객체 얻어오기
            PlayerFire player =
                GameObject.Find("Player").GetComponent<PlayerFire>();
            // 오브젝트 풀 리스트에 총알 삽입
            player.bulletObjectPool.Add(other.gameObject);
        }
        else if (other.CompareTag("Enemy"))
        {
            // 부딪힌 물체를 비활성화
            other.gameObject.SetActive(false);
            // EnemyManager 객체 얻어오기
            EnemyManager em =
                GameObject.Find("EnemyManager").GetComponent<EnemyManager>();
            int enemyIdx = other.GetComponent<Enemy>().enemyIdx;
            // 오브젝트 풀 리스트에 에너미 삽입
            em.enemyObjectPool[enemyIdx].Add(other.gameObject);
        }
        else
        {
            //그 물체를 없애고 싶다.
            Destroy(other.gameObject);
        }
    }
}
