using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManagerStage01 : MonoBehaviour
{
    //게임돈 관련
    public TMP_Text goldText;

    //플레이어 hp 관련
    public GameObject HP;
    Image hpImg;
    Sprite[] hpImags;
    PlayerMove playerMove;

    //모래시계 조작 관련
    public GameObject hourGlass;
    Image hourGlassImg;
    Sprite[] hourGlassImgs;
    Sprite[] hourGlassResetImgs;
    public GameObject player;
    bool timeAttack;


    //PUSH START BUTTON ONE OR TWO PLAYERS _ Menu02
    public Text PlayerOneUI;
    public Text PlayerTwoUI;
    public float MenuBlinkTime = 1.5f;//깜빡 주기    


    void Start()
    {
        //골드 UI 업데이트 관련
        UpdateGameMoneyUI();

        //HP 업데이트 관련
        hpImg = HP.GetComponent<Image>();
        hpImags = HP.GetComponent<HPRender>().hpImages;

        //모래시계 업데이트 관련

        hourGlassImg = hourGlass.GetComponent<Image>();
        hourGlassImgs = hourGlass.GetComponent<HourGlassRender>().HourGlassImgs;
        hourGlassResetImgs = hourGlass.GetComponent<HourGlassRender>().HourGlassResetImgs;

        //플레이어의 트랜스폼 컴포넌트 가져옴
        playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();


        PlayerOneUI.text = "Player 1";
        PlayerTwoUI.text = "Player 2";

        StartCoroutine(HourGlassUpdate());  //모래시계 Update 함수        
    }
    void Update()
    {
        HpState(); //HP Update 함수

        // Player 1, 2 깜빡 거림 처리
        /*
         Time.unscaledTime
         게임이 시작된 뒤 흐른 실제 시간(초)
         Time.time과 달리 Time.timeScale 영향을 받지 않음 (일시정지해도 계속 증가)
         */
        float t = Mathf.Repeat(Time.unscaledTime, MenuBlinkTime) / MenuBlinkTime;
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

    }

    IEnumerator HourGlassUpdate()
    {
        int i = 0;
        while (true)
        {
            hourGlassImg.sprite = hourGlassImgs[i];
            yield return new WaitForSeconds(1f);
            i = (i + 1) % hourGlassImgs.Length;

            if (i == 0)
            {
                for (int j = 0; j < hourGlassResetImgs.Length; j++)
                {
                    if (!timeAttack)
                    {
                        timeAttack = true;
                        player.GetComponent<PlayerMove>().Damaged(10);
                    }
                    hourGlassImg.sprite = hourGlassResetImgs[j];
                    yield return new WaitForSeconds(0.5f);
                }
                timeAttack = false;
            }
        }
    }

    void HpState()
    {
        int hp = PlayerPrefs.GetInt("HP");

        switch (hp)
        {
            case 50: hpImg.sprite = hpImags[10]; break;
            case 45: hpImg.sprite = hpImags[9]; break;
            case 40: hpImg.sprite = hpImags[8]; break;
            case 35: hpImg.sprite = hpImags[7]; break;
            case 30: hpImg.sprite = hpImags[6]; break;
            case 25: hpImg.sprite = hpImags[5]; break;
            case 20: hpImg.sprite = hpImags[4]; break;
            case 15: hpImg.sprite = hpImags[3]; break;
            case 10: hpImg.sprite = hpImags[2]; break;
            case 5: hpImg.sprite = hpImags[1]; break;
            case 0:
                hpImg.sprite = hpImags[1];
                playerMove.Die();
                break;
        }
    }

    public void UpdateGameMoneyUI()
    {
        if (GameMoneyManager.Instance != null)
        {
            goldText.text = GameMoneyManager.Instance.currentCoin.ToString();
        }
        else
        {
            goldText.text = PlayerPrefs.GetInt("GameMoney", 0).ToString();
        }
    }


}
