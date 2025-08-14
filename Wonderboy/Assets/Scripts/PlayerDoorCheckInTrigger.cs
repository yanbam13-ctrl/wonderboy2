using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorCheckInTrigger : MonoBehaviour
{
    private bool isInDoorTrigger = false;
    private Transform doorTransform;
    private DoorManager dm;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("Door Trigger Enter");
            isInDoorTrigger = true;
            dm = other.GetComponent<DoorManager>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Door Trigger Exit");

        if (other.CompareTag("Door"))
        {
            Debug.Log("Door Trigger Enter");
            isInDoorTrigger = false;
            dm = null;
        }
    }

    private void Update()
    {
        if (isInDoorTrigger && Input.GetKeyDown(KeyCode.UpArrow))
        {
            //플레이어가 문의 앞쪽에 있는지 확인
            float distance = Mathf.Abs(transform.position.x - dm.transform.position.x);

            if (distance <= 0.5f)
            {
                //Debug.Log($"availableCount: {dm.availableCount}");
                //Debug.Log($"확인: {dm.availableCount == 1}");

                if (dm.availableCount >= 1)
                {
                    dm.LoadScene(dm.sceneName);

                }

                else
                {
                    Debug.Log($"문을 열수 있는 기회는 {dm.availableCount}으로 " +
                        $"이 문은 닫혀 있어 들어가지 못합니다.");
                }
            }
            else
            {
                Debug.Log("Too far from door front");
            }
        }
    }
}
