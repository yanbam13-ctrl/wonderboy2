using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 씬 전환에 필요

public class UIManagerOne : MonoBehaviour
{
    //InsertCoinView _ Menu01
    public Text istCoinTxt;
    public float MenuOneperiod = 0.2f;//깜빡 주기
    private float MenuOnetimer;

    public Text Credit;
    public string nextSceneName = "Menu02"; // 전환할 씬 이름    

    void Start()
    {
        // *** PlayerPrefs 값 초기화 ***
        PlayerPrefs.DeleteKey("DoorCount_Door01"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey("DoorCount_BossRoomDoorOpen_"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey($"Stage01_BrickBounce"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey("SwordId"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey("GameMoney"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey("HP");

        CoinManager.Instance.ResetCoin();
        istCoinTxt.text = "Insert Coin";
        Credit.text = "CREDIT 0";
    }

    void Update()
    {
        //InsertCoin 깜빡거림처리
        MenuOnetimer += Time.deltaTime;
        if (MenuOnetimer >= MenuOneperiod)
        {
            istCoinTxt.gameObject.SetActive(!istCoinTxt.gameObject.activeSelf);
            MenuOnetimer = 0f;
        }

        //Insert Coin
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            CoinManager.Instance.AddCoin(1);
            Credit.text = "CREDIT " + CoinManager.Instance.Coin;
            SceneManager.LoadScene(nextSceneName);
        }
        
    }
}
