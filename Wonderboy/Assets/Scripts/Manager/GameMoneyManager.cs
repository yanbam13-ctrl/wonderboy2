using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMoneyManager : MonoBehaviour
{
    public GameObject coin;
    public static GameMoneyManager Instance = null;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }

    //«√∑π¿ÃæÓ∞° Coin¿ª »πµÊ

    public void GetGameMoney(int coinValue)
    {
        print("GetGameMoney() µø¿€");
        int currentCoin = PlayerPrefs.GetInt("GameMoney");

        currentCoin += coinValue;

        PlayerPrefs.SetInt("GameMoney", currentCoin);

        print(PlayerPrefs.GetInt("GameMoney"));
    }



}
