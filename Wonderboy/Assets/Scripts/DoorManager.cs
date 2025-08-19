using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorManager : MonoBehaviour
{
    SpriteRenderer sp;
    public Sprite closeDoor;
    private Animator animator;

    public int availableCount; //출입 가능 횟수
    public string sceneName; //로드할 씬 이름
    public float openDelay = 0.5f; // 애니메이션 재생후 기다릴 시간

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        if (availableCount == 0)
            CloseDoor();
    }


    public void CloseDoor()
    {
        // Sprite 변경
        sp.sprite = closeDoor;

        // 원래 스케일 다시 적용
        sp.transform.localScale = new Vector3(1.128269f, 1.088447f, 1.0619f);
        sp.transform.position = new Vector3(11.233f, -2.47f, 0f);
    }


    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadAfterOpen(sceneName));
    }

    IEnumerator LoadAfterOpen(string sceneName)
    {
        availableCount--; // 출입 카운터 차감

        //animator.ResetTrigger("OpenDoor");
        animator.SetTrigger("OpenDoor"); // 문열림 애니메이션 재생

        yield return new WaitForSeconds(openDelay); //0.5f 대기

        SceneManager.LoadScene(sceneName);
    }
    //SwordRoom일 경우
}


    //public void OpenDoor() {
    //    Debug.Log("OpenDoor");
    //    animator.SetTrigger("OpenDoor");
    //}

    //public void LoadScene(string sceneName)
    //{
    //    OpenDoor();
    //    Debug.Log("LoadScene : " + sceneName);
    //    SceneManager.LoadScene(sceneName);
    //    availableCount--;

    //    //씬이 전환이 된 후에 문이 닫히게 해야함.
    //    //이 사이에 텀을 주기 위한 코드

    //}


