using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{

    // 사용자 데이터를 새로 저장하거나 저장된 데이터를 읽어 사용자의 입력과 일치하는지 검사하게 하고 싶다.

    // 유저 아이디 변수
    public TMP_InputField id;

    // 유저 패스워드 변수
    public TMP_InputField password;

    // 검사 텍스트 변수
    public TMP_Text notify;

    void Start()
    {
        if (notify == null)
        {
            // 검사 텍스트 창을 비운다.
            notify.text = "";
        }

    }

}
