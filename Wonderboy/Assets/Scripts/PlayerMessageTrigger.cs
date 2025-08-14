using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMessageTrigger : MonoBehaviour
{
    public MessageController mc;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 태그로 필터링(선택)
        if (!other.CompareTag("MessageTrigger")) return;

        MessageData data = other.GetComponent<MessageData>();

        if (data.MessageTrigger)
        {
            if (data != null)
                mc.ShowMessage(data.message,
                    data.pauseGame,
                    data.waitForInput,
                    data.charDelay,
                    data.autoCloseAfter);

            data.MessageTrigger = false;
        }

    }
}
