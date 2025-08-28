using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMessageTrigger : MonoBehaviour
{
    public MessageController mc;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("start");

        // 태그로 필터링(선택)
        //if (!other.CompareTag("MessageTrigger")) return;

        MessageData data = other.GetComponent<MessageData>();

        // 메세지 데이터 유무로 필터링
        if (data == null) return;

        //Debug.Log(data.MessageTrigger);
        //Debug.Log(data.message);

        //실행된 적이 없다면
        if (data.MessageTrigger)
        {
            //messageController 메서드 호출
            if (data != null)
                mc.ShowMessage(data);
        }

        //Debug.Log("end");
    }
}
