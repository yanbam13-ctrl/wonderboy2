using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinZone : MonoBehaviour
{
    public GameObject coin;

    //플레이어가 CoinZone을 지나가면 동전 생성
    private void OnTriggerEnter2D(Collider2D other)
    {
        //CoinZone과 접촉한 오브젝트가 플레이어가 아니라면 리턴
        if (!other.gameObject.CompareTag("Player")) return;

        //CoinZone과 접촉한 오브젝트가 플레어일때 동전을 생성

        //동전의 위치를 플레이어 머리위에 생성하기
        Vector2 playerPosition = other.transform.position;

        playerPosition.y += 1.0f;

        Instantiate(coin, playerPosition, Quaternion.identity);
    }
}
