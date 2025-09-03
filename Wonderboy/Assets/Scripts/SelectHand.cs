//using UnityEngine;

//public class GameOverSelector : MonoBehaviour
//{
//    public Transform[] cursorPositions; // 손이 갈 수 있는 위치들
//    public GameObject cursor;           // 손 이미지
//    int currentIndex = 0;               // 0 = Continue, 1 = Quit

//    void Update()
//    {
//        // 좌우 입력으로 인덱스 변경
//        if (Input.GetKeyDown(KeyCode.LeftArrow))
//        {
//            currentIndex = Mathf.Max(0, currentIndex - 1);
//            MoveCursor();
//        }
//        else if (Input.GetKeyDown(KeyCode.RightArrow))
//        {
//            currentIndex = Mathf.Min(cursorPositions.Length - 1, currentIndex + 1);
//            MoveCursor();
//        }

//        // 선택 확정
//        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Return))
//        {
//            if (currentIndex == 0)
//            {
//                Debug.Log("Continue 선택됨");
//                // 이어서 플레이 로직
//            }
//            else
//            {
//                Debug.Log("Quit 선택됨");
//                // 타이틀로 나가기 or 게임 종료
//            }
//        }
//    }

//    void MoveCursor()
//    {
//        cursor.transform.position = cursorPositions[currentIndex].position;
//    }
//}