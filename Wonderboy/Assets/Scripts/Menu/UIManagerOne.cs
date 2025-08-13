using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // ¾À ÀüÈ¯¿¡ ÇÊ¿ä

public class UIManagerOne : MonoBehaviour
{
    //InsertCoinView _ Menu01
    public Text istCoinTxt;
    public float MenuOneperiod = 0.2f;//±ôºý ÁÖ±â
    private float MenuOnetimer;

    public Text Credit;
    public string nextSceneName = "Menu02"; // ÀüÈ¯ÇÒ ¾À ÀÌ¸§    

    void Start()
    {
        CoinManager.Instance.ResetCoin();
        istCoinTxt.text = "Insert Coin";
        Credit.text = "CREDIT 0";
    }

    void Update()
    {
        //InsertCoin ±ôºý°Å¸²Ã³¸®
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
