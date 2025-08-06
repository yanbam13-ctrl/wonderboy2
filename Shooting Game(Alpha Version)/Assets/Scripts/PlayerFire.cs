using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //총알 생산할 공장
    public GameObject bulletFactory; // 큐브 오브젝트 적용

    //탄창에 넣을 총알 개수
    public int poolSize; // 10

    //오브젝트풀 배열
    GameObject[] bulletObjectPool;

    //총구
    public GameObject firePosition;

    private void Start()
    {
        //탄창의 크기를 총알을 담을 수 있는 크기로 만들어 준다.
        bulletObjectPool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {

            //총알 공장에서 총알을 생성한다.
            GameObject bullet = Instantiate(bulletFactory);

            //총알을 오브젝트 풀에 넣는다.
            bulletObjectPool[i] = bullet;
            bullet.SetActive(false);
        }
    }

    void Update()
    {
        //목표: 사용자가 발사 버튼을 누르면 총알을 발사하고 싶다.
        //순서 : 1.사용자가 발사 버튼을 누르면
        // - 만약 사용자가 발사 버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            /*
            //2.총알 공장에서 총알을 만든다.
            GameObject bullet = Instantiate(bulletFactory);
            */

            for (int i = 0; i < poolSize; i++)
            {

                //비활성화 된 총알을
                GameObject bullet = bulletObjectPool[i];
                if (bullet.activeSelf == false)
                {
                    //발사 (활성화 시킨다.)
                    bullet.SetActive(true);
                    //총알을 위치시킨다. // //3.총알을 발사한다.(총알을 총구위치로 가져다 놓기)
                    bullet.transform.position = firePosition.transform.position;
                    //총알을 발사했기 때문에 비활성화 총알 검색을 중단.
                    break;
                }

            }

        }
    }
}
