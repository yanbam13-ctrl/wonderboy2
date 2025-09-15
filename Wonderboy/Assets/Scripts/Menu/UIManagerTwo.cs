using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagerTwo : MonoBehaviour
{

    //PUSH START BUTTON ONE OR TWO PLAYERS _ Menu02
    public Text PlayerOneUI;
    public Text PlayerTwoUI;
    public Text MessageUI;
    public Text Credit;
    public float MenuTwoperiod = 1.5f;//깜빡 주기    
    public string nextSceneName = "Stage01";

    void Start()
    {
        PlayerOneUI.text = "Player 1";
        PlayerTwoUI.text = "Player 2";
        MessageUI.text = "PUSH START BUTTON \r\nONE OR TWO PLAYERS";
        Credit.text = "CREDIT " + CoinManager.Instance.Coin;
    }

    void Update()
    {
        // Player 1, 2 깜빡 거림 처리
        /*
         Time.unscaledTime
         게임이 시작된 뒤 흐른 실제 시간(초)
         Time.time과 달리 Time.timeScale 영향을 받지 않음 (일시정지해도 계속 증가)
         */
        float t = Mathf.Repeat(Time.unscaledTime, MenuTwoperiod) / MenuTwoperiod;
        /*         
         Mathf.Repeat(a, b)
         a를 b로 나눈 나머지를 반환 (0 이상 b 미만)
         즉, MenuTwoperiod마다 값이 0으로 리셋됨 → 주기적인 값 만들기

        / MenuTwoperiod
          0 ~ MenuTwoperiod 구간을 0~1 범위로 정규화
          ➡ 결과적으로 t는 0에서 1까지 반복되는 값이 되고, 한 주기(MenuTwoperiod초)마다 다시 0으로 돌아옴.
         */

        bool on = t < 0.5f;
        PlayerOneUI.gameObject.SetActive(on);
        PlayerTwoUI.gameObject.SetActive(!on);


        //Insert Coin -> credit 
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            CoinManager.Instance.AddCoin(1);
            Credit.text = "CREDIT " + CoinManager.Instance.Coin;
        }

        if (CoinManager.Instance.Coin > 0)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }

    }
}
