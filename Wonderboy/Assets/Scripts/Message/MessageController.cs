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
    private MessageData currentData;



    public void ShowMessage(MessageData data)
    {
        currentData = data;

        StartCoroutine(ShowRoutine(data));
    }

    IEnumerator ShowRoutine(MessageData data)
    {
        if (data.pauseGame)
        {
            Time.timeScale = 0f; // 구간 한정 일시 정지
            messageUI.SetActive(true);
            //messageText.text = "";

            //한 글자씩 출력(타임스케일 0에서도 동작하도록 realtime 대기)
            string[] pages = data.message.Split(new string[] { "\\n" }, System.StringSplitOptions.None);

            foreach (string page in pages)
            {
                messageText.text = "";

                for (int i = 0; i < page.Length; i++)
                {
                    char c = page[i];

                    if (c == '\\') // 백슬래시 → 강제 줄바꿈
                    {
                        messageText.text += "\n";
                    }
                    else
                    {
                        messageText.text += c;
                        yield return new WaitForSecondsRealtime(data.charDelay);
                    }
                }

                // 한 페이지 끝 → 입력 대기
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.LeftControl));

                //메세지 재실행을 막기 위해 MessageTrigger 값 변경
            }

            //foreach (char c in text)
            //{
            //    messageText.text += c;
            //    yield return new WaitForSecondsRealtime(charDelay);
            //}

            //종료 대기 : 입력 or 자동
            if (data.waitForInput && data.autoCloseAfter <= 0f)
            {
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.LeftControl));
                Time.timeScale = 1f; //재개
            }
            else if (data.autoCloseAfter > 0f)
            {
                Time.timeScale = 1f; //재개
                yield return new WaitForSecondsRealtime(data.autoCloseAfter);
                messageUI.SetActive(false);
            }
        }
        else
        {
            messageUI.SetActive(true);
            messageText.text = data.message;

            yield return new WaitForSecondsRealtime(data.autoCloseAfter);
            messageUI.SetActive(false);

        }

        data.MessageTrigger = false;
    }


}