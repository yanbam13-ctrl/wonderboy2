using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverIntro : MonoBehaviour
{
    public MessageController mc;
    public MessageData md;
    public GameObject gameOverSelect;
    public GameObject selectHand;
    //public string nextSceneName = "Stage01";

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey($"Stage01_BrickBounce"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey("GameMoney"); //PlayerPrefs 값 초기화
        PlayerPrefs.DeleteKey("HP");

        // 메세지 데이터 유무로 필터링
        if (md == null) return;
        Debug.Log(md.message);

        //실행된 적이 없다면
        if (md.MessageTrigger)
        {
            //messageController 메서드 호출
            if (md != null)
            {
                StartCoroutine(GameMessageDelay());
            }
        }
        Debug.Log("end");
    }

    IEnumerator GameMessageDelay()
    {
        mc.ShowMessage(md);
        yield return new WaitForSeconds(0.5f);
        gameOverSelect.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        selectHand.SetActive(true);

    }

    private void Update()
    {

    }
}
