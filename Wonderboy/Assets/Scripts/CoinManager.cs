using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance = null;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    //공통으로 관리할 코인
    private int coin;



    private void Start()
    {
        coin = PlayerPrefs.GetInt("Coin");
    }
    public int Coin { get { return coin; } }
    public void AddCoin(int value = 1)
    {
        coin += value;
        PlayerPrefs.SetInt("Coin", coin);
        PlayerPrefs.Save();
    }

    public void DelCoin() {
        coin--;
        PlayerPrefs.SetInt("Coin", coin);
        PlayerPrefs.Save();
    }

    public void SetCoin(int value)
    {
        coin = value;
        PlayerPrefs.SetInt("Coin", coin);
        PlayerPrefs.Save();
    }

    public void ResetCoin()
    {
        coin = 0;
        PlayerPrefs.DeleteKey("Coin");
    }
}
