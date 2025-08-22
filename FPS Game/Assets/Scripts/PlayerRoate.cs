using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoate : MonoBehaviour
{
    //회전 속도 변수
    public float rotSpeed; // 200f;

    //회전 값 변수
    float mx = 0;

    private void Update()
    {
        //게임 상태가 '게임 중' 상태 일때만 조작할수 있게 한다.
        if (GameManager.gm.gState != GameManager.GameState.Run) return;


        //사용자 마우스 입력을 받아 플레이어를 회전
        //1. 마우스 좌우 입력을 받음

        float mouse_X = Input.GetAxis("Mouse X");

        //1-1. 회전 값 변수에 마우스 입력 값 만큼 미리 누적
        mx += mouse_X * rotSpeed * Time.deltaTime;

        //2. 회전 방향으로 물체를 회전시킴
        transform.eulerAngles = new Vector3(0, mx, 0);
    }

}
