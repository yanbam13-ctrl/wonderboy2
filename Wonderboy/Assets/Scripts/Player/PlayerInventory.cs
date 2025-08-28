using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInventory : MonoBehaviour
{
    public GameObject swordIdle;
    public GameObject swordJump;
    public GameObject swordAttack;
    public bool isJump = false;
    public bool isAttack = false;
    public TMP_Text goldText;

    int playerGameMoney;

    

    private void Start()
    {
        Apply();
    }

    void Apply()
    {
        bool hasSword = SaveInventory.SwordId >= 0;

        // 기본은 전부 끄고 시작
        if (swordIdle) swordIdle.SetActive(false);
        if (swordJump) swordJump.SetActive(false);
        if (swordAttack) swordAttack.SetActive(false);

        if (!hasSword) return;

        if (isAttack)
        {
            if (swordAttack) swordAttack.SetActive(true);
        }
        else if (isJump)
        {
            if (swordJump) swordJump.SetActive(true);
        }
        else
        {
            if (swordIdle) swordIdle.SetActive(true);
        }
    }

    // 애니메이션 이벤트/상태 전환에서 호출
    public void AttackStart()
    {
        isAttack = true; 
        Apply();
    }
    public void AttackEnd()
    {
        isAttack = false; 
        Apply();
    }

    public void SwordStateJump(bool on)
    {
        isJump = on;
        Apply();
    }


    // 동전 획득

    //private void OnTriggerEnter2D(Collider2D c)
    //{
    //    Debug.Log($"충돌한 오브젝트의 이름 : {c.name}");

    //    if (!c.CompareTag("Coin")) return;

    //    Coin coin = c.GetComponent<Coin>();

    //    GameMoneyManager.Instance.GetGameMoney(coin.coinValue);

    //}

    private void OnCollisionEnter2D(Collision2D c)
    {
        Debug.Log($"충돌한 오브젝트의 이름 : {c.transform.gameObject.name}");
        Debug.Log($"메서드 발동 조건 : {!c.transform.CompareTag("Coin")}");

        if (!c.transform.CompareTag("Coin")) return;

        Coin coin = c.transform.GetComponent<Coin>();
        GameMoneyManager.Instance.GetGameMoney(coin.coinValue);
        Destroy(c.gameObject);

        playerGameMoney = PlayerPrefs.GetInt("GameMoney");

        Debug.Log("GameMoneyManager.Instance " +( GameMoneyManager.Instance == null));

    }



}
