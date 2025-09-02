using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorManager : MonoBehaviour
{

    SpriteRenderer sp;
    public Sprite CloseDoorSP;
    private Animator animator;

    public int availableCount; //출입 가능 횟수
    public string sceneName; //로드할 씬 이름
    public float openDelay = 0.5f; // 애니메이션 재생후 기다릴 시간

    string doorId;   // 비워두면 자동으로 name 사용

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        if (string.IsNullOrEmpty(doorId)) doorId = gameObject.name;
    }

    private void Start()
    {
        //PlayerPrefs.DeleteKey($"DoorCount_{doorId}"); //PlayerPrefs 값 초기화
        //PlayerPrefs.DeleteKey($"Stage01_BrickBounce"); //PlayerPrefs 값 초기화
        //PlayerPrefs.DeleteKey("SwordId"); //PlayerPrefs 값 초기화
        //PlayerPrefs.DeleteKey("GameMoney"); //PlayerPrefs 값 초기화


        // 저장된 값이 있으면 복원 (없으면 인스펙터 값 유지)
        availableCount = PlayerPrefs.GetInt($"DoorCount_{doorId}", availableCount);

        if (availableCount == 0)
            CloseDoor();
    }


    public void CloseDoor()
    {
        if (animator)
        {
            animator.ResetTrigger("OpenDoor");
            animator.Play("Closed", 0, 0f);  // 상태 강제 전환
            animator.Update(0f);             // 즉시 반영
            animator.enabled = false;        // 닫힌 동안 애니 꺼두기
        }
        // Sprite 변경
        sp.sprite = CloseDoorSP;
        //print("CloseDoor");


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
        PlayerPrefs.SetInt($"DoorCount_{doorId}", availableCount); // 저장
        PlayerPrefs.Save();

        if (animator && !animator.enabled) animator.enabled = true;
        animator.ResetTrigger("OpenDoor");
        animator.SetTrigger("OpenDoor"); // 문열림 애니메이션 재생

        // 1) 전이 반영을 위해 1프레임 대기
        yield return null;

        // 2) 실제로 Open 상태로 들어갈 때까지 대기 (타임아웃 포함)
        float enterTimeout = 2f;
        float t = 0f;

        while (!animator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor") && t < enterTimeout)
        {
            t += Time.unscaledDeltaTime;
            yield return null;
        }


        // 3) Open 상태가 1회 재생 완료될 때까지 대기 (타임아웃 포함)
        float playTimeout = 5f;
        t = 0f;
        while (animator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor") &&
               animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f &&
               t < playTimeout)
        {
            t += Time.unscaledDeltaTime;
            yield return null;
        }

        //yield return new WaitForSeconds(openDelay); //0.5f 대기

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


