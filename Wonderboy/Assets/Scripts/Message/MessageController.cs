using System.Collections;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    float startWaitTime = 1.5f;

    public GameObject messageUI;               // 메시지 전체 UI
    public TextMeshProUGUI messageText;        // 메시지 텍스트

    public void ShowMessage(string text)
    {
        messageText.text = text;
        messageUI.SetActive(true);
        StartCoroutine(HideAfterDelay());
    }
    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        messageUI.SetActive(false);
    }
}