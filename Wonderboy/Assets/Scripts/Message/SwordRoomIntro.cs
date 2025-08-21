using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwordRoomIntro : MonoBehaviour
{
    public MessageController mc;
    public MessageData md;
    public string nextSceneName = "Stage01";

    // Start is called before the first frame update
    void Start()
    {

        // 메세지 데이터 유무로 필터링
        if (md == null) return;
        Debug.Log(md.message);

        //실행된 적이 없다면
        if (md.MessageTrigger)
        {
            //messageController 메서드 호출
            if (md != null)
                mc.ShowMessage(md);

        }

        Debug.Log("end");
    }

    private void Update()
    {
        if (!md.MessageTrigger)
        {
            SaveInventory.SwordId = 0;  // 장착(표시할 종류)
            SaveInventory.SetOwned("sword_01", true); // (선택) 소유 목록에 기록

            SaveFlags.SetBool(SaveFlags.Stage01_BrickBounce, true);

            SceneManager.LoadScene(nextSceneName);
        }
    }

}
