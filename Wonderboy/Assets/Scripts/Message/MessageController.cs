using System.Collections;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MessageController : MonoBehaviour
{
    public GameObject messageUI; // 메시지 전체 UI
    public TextMeshProUGUI messageText; // 메시지 텍스트

    public void ShowMessage(string text, bool pause,
        bool waitForInput, float charDelay, float autoCloseAfter)
    {
        StartCoroutine(ShowRoutine(text, pause, waitForInput, charDelay, autoCloseAfter));
    }

    IEnumerator ShowRoutine(string text, bool pause,
        bool waitForInput, float charDelay, float autoCloseAfter)
    {
        if (pause)
        {
            Time.timeScale = 0f; // 구간 한정 일시 정지
            messageUI.SetActive(true);
            messageText.text = "";
            //한 글자씩 출력(타임스케일 0에서도 동작하도록 realtime 대기)

            foreach (char c in text)
            {
                messageText.text += c;
                yield return new WaitForSecondsRealtime(charDelay);
            }

            //종료 대기 : 입력 or 자동
            if (waitForInput && autoCloseAfter <= 0f)
            {
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.LeftControl));
                Time.timeScale = 1f; //재개
            }
            else if (autoCloseAfter > 0f)
            {
                Time.timeScale = 1f; //재개
                yield return new WaitForSecondsRealtime(autoCloseAfter);
                messageUI.SetActive(false);
            }
        }
        else
        {
            messageUI.SetActive(true);
            messageText.text = text;

            yield return new WaitForSecondsRealtime(autoCloseAfter);
            messageUI.SetActive(false);

        }

    }
}