using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
public class PlayerInventory : MonoBehaviour
{
    public GameObject swordIdle;
    public GameObject swordJump;
    public GameObject swordAttack;
    public bool isJump = false;
    public bool isAttack = false;
    private UIManagerStage01 uiManager;
    private MessageController messageController;

    private void Start()
    {
        Apply();
        uiManager = FindObjectOfType<UIManagerStage01>();
        messageController = FindObjectOfType<MessageController>();
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

    //코인 충돌시 획득 처리
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (!c.transform.CompareTag("Coin")) return;

        Coin coin = c.transform.GetComponent<Coin>();
        if (coin == null) return;

        // 중복 처리 방지: 충돌 직후 코인 콜라이더 비활성화
        var col = coin.GetComponent<Collider2D>();
        if (col) col.enabled = false;

        MessageData data = coin.GetComponent<MessageData>();

        // 획득 코인을 GameMoneyManager.cs의 currentCoin에 더하고 currentCoin을 PlayerPrefs.SetInt("GameMoney", 충돌된 코인이 가지고 있는 코인값);
        GameMoneyManager.Instance.GetGameMoney(coin.coinValue);

        print($"PlayerInventory.cs의  messageController :-> {messageController != null}");
        print($"PlayerInventory.cs MessageData-> {data != null}");
        print($"PlayerInventory.cs MessageData.Message : {data.message}");

        messageController.ShowMessage(data);

        //UI 갱신 호출
        if (uiManager != null)
        {
            //UIManagerStage01에에 있는 메서드
            //GameManager(인스턴스)를 가져와 currentCoin 값을 UI에 표시            
            uiManager.UpdateGameMoneyUI();
        }
        else
        {
            Debug.LogWarning("UIManagerStage01 참조가 없습니다.");
        }

        Destroy(c.gameObject);
    }



}
