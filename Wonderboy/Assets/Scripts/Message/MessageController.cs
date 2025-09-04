using System.Collections;
using TMPro;
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
        print("1. MessageController의 ShowMessage 동작");
        currentData = data;

        StartCoroutine(ShowRoutine(data));
    }

    IEnumerator ShowRoutine(MessageData data)
    {
        print("2. IEnumerator ShowRoutine(MessageData data) 동작");
        if (data.pauseGame)
        {
            print("3. if (data.pauseGame) true");
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
                // ★ 페이지 끝 대기: 입력을 기다릴 때만
                if (data.waitForInput)
                {
                    print($"3-1. {data.message} / data.waitForInput && data.autoCloseAfter <= 0f ");
                    yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.LeftControl));
                }  // waitForInput == false면 바로 다음 페이지로 진행 (대기 없음)

                //메세지 재실행을 막기 위해 MessageTrigger 값 변경
            }

            //foreach (char c in text)
            //{
            //    messageText.text += c;
            //    yield return new WaitForSecondsRealtime(charDelay);
            //}

            //종료 대기 : 입력 or 자동
            // ★ 전체 메시지 출력이 끝난 후: 자동 닫기 시간이 있으면 그만큼 대기
            if (data.waitForInput && data.autoCloseAfter <= 0f)
            {
                print($"3-2. {data.message} / data.waitForInput && data.autoCloseAfter <= 0f ");
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.LeftControl));
            }
            else if (data.autoCloseAfter > 0f)
            {
                print($"3-3. {data.message} / data.autoCloseAfter > 0f {Time.deltaTime}");
                yield return new WaitForSecondsRealtime(data.autoCloseAfter);
                //messageUI.SetActive(false);
            }

            // 공통 마무리(항상 실행)
            Time.timeScale = 1f;

            yield return new WaitForSecondsRealtime(data.endWaitSecond);
            messageUI.SetActive(false);
        }
        else
        {
            print("3. if (data.pauseGame) false");
            messageUI.SetActive(true);
            messageText.text = data.message;

            yield return new WaitForSecondsRealtime(data.autoCloseAfter);
            messageUI.SetActive(false);

        }

        data.MessageTrigger = false;
    }


}