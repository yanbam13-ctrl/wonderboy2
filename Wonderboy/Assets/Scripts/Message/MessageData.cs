using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageData : MonoBehaviour
{
    public bool pauseGame = false; // 멈춘후 메시지 출력 여부
    public bool waitForInput = true;  // 메시지 끝나고 키 입력 기다릴지
    public float charDelay = 1f; // 한글자 출력 간격(초)
    public float autoCloseAfter = 0f;    // 0이면 입력 대기, >0이면 실시간으로 자동 종료
    public string message; // 메시지
    public bool MessageTrigger = true; //한번만 출력하도록 하기
    public float endWaitSecond = 1f;
}
