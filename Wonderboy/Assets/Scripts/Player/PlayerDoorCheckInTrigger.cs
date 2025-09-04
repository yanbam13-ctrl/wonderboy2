using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorCheckInTrigger : MonoBehaviour
{
    bool isInDoorTrigger = false;
    bool isTransitioning = false;

    private DoorManager dm;
    Animator playerAnim;

    //float knockDuration = 0.35f;  // 클립 길이에 맞춰 조정
    string knockParam = "IsKnocking"; // Animator 파라미터 이름
    string knockState = "Nocking";    // 상태 이름(애니메이터 상 이름과 정확히 일치)

    void Awake()
    {
        playerAnim = GetComponent<Animator>();
    }

    private void Start()
    {
        float x = PlayerPrefs.GetFloat("PlayerPosX", transform.position.x);
        float y = PlayerPrefs.GetFloat("PlayerPosY", transform.position.y);

        transform.position = new Vector3(x, y, 0);

        PlayerPrefs.DeleteKey("PlayerPosX");
        PlayerPrefs.DeleteKey("PlayerPosY");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door") && !isInDoorTrigger)
        {
            //Debug.Log("Door Trigger Enter");
            isInDoorTrigger = true;
            dm = other.GetComponent<DoorManager>();
            Debug.Log(dm.availableCount);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Door Trigger Exit");

        if (other.CompareTag("Door"))
        {
            //Debug.Log("Door Trigger Enter");
            isInDoorTrigger = false;
            dm = null;
            isTransitioning = false;
        }
    }

    private void Update()
    {
        if (!isInDoorTrigger || isTransitioning || dm == null) return;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //플레이어가 문의 앞쪽에 있는지 확인
            float distance = Mathf.Abs(transform.position.x - dm.transform.position.x);

            if (distance > 0.5f)
            {
                Debug.Log("Too far from door front");
                return;
            }
            if (dm.availableCount < 1)
            {
                Debug.Log($"문을 열수 있는 기회는 {dm.availableCount}으로 " +
                        $"이 문은 닫혀 있어 들어가지 못합니다.");
                return;
            }

            //isInDoorTrigger -> 플레이어가 문의 범위 안에 들어 왔고
            //availableCount가 모두 소진되지 않아서 문으로 접근이 가능할때
            //그리고 방향키 Up을 눌렀을때

            StartCoroutine(KnockThenOpen());


            // 씬 전환 전에
            //PlayerPrefs.SetFloat("PlayerPosX", transform.position.x);
            //PlayerPrefs.SetFloat("PlayerPosY", transform.position.y);

            //playerAnim.SetTrigger("IsKnocking");

            //dm.LoadScene(dm.sceneName);

        }
    }

    IEnumerator KnockThenOpen()
    {
        isTransitioning = true;
        transform.Find("SwordIdle").gameObject.SetActive(false);

        //노크 트리거
        if (playerAnim) {
            playerAnim.ResetTrigger(knockParam);
            playerAnim.SetTrigger(knockParam);
        }

        // (A) 상태 종료를 정확히 기다리기 — 추천
        yield return null; // 전이 반영 1프레임
        yield return new WaitUntil(() => {
            var s = playerAnim.GetCurrentAnimatorStateInfo(0);
            return s.IsName(knockState) && s.normalizedTime >= 1f;
        });

        //yield return new WaitForSeconds(knockDuration);

        //위치 저장 후 문 열기(씬 전환)
        PlayerPrefs.SetFloat("PlayerPosX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerPosY", transform.position.y);

        dm.LoadScene(dm.sceneName);

    }
}
