using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public InputField nameInput;
    public GameObject bestData;
    public Text bestUserData;

    public void GoPlay()
    {
        // 1. 이름을 입력하지 않고 START 하는 경우 플레이화면으로 넘어가지 않도록 한다.
        //Debug.Log(nameInput.text == "");
        //if (nameInput.text == "") return;

        if (string.IsNullOrWhiteSpace(nameInput.text) || string.IsNullOrEmpty(nameInput.text)) return; // tab 키도 필터링 가능 _ 성능이 좀 떨어지는 단점

        /*  */

        PlayerPrefs.SetString("UserName", nameInput.text);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainPlay");
    }

    public void BestScore()
    {
        if (PlayerPrefs.HasKey("BestPlayer"))
        {
            bestUserData.text = "";
            for (int i = 0; i < 3; i++)
            {
                bestUserData.text += string.Format(
                "{0}. {1}:{2:N0}\n",
                i + 1,
                PlayerPrefs.GetString("BestPlayer" + i),
                PlayerPrefs.GetFloat("BestScore" + i));

                bestData.SetActive(true);
            }

        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
