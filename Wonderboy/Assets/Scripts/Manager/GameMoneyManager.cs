using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMoneyManager : MonoBehaviour
{
    public GameObject coin;
    public static GameMoneyManager Instance = null;
    public int currentCoin;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }

        currentCoin = PlayerPrefs.GetInt("GameMoney");

        print($"처음 currentCoin 값 : {currentCoin}");

    }

    //플레이어가 Coin을 획득

    public void GetGameMoney(int coinValue)
    {
        print("GetGameMoney() 동작");

        currentCoin += coinValue;

        PlayerPrefs.SetInt("GameMoney", currentCoin);
        PlayerPrefs.Save();

        print($"GameMoneyManger Class에서 PlayerPrefs GetInt : {PlayerPrefs.GetInt("GameMoney")}");
    }



}
