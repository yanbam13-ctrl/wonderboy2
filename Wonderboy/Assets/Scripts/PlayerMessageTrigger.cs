using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMessageTrigger : MonoBehaviour
{
    public MessageController mc;



    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
        Debug.Log(other.CompareTag("MessageTrigger"));
        Debug.Log(other.tag);
        // 태그로 필터링(선택)
        if (!other.CompareTag("MessageTrigger")) return;

        MessageData data = other.GetComponent<MessageData>();

        Debug.Log(data.message);

        if(data != null)
        mc.ShowMessage(data.message);

    }
}
