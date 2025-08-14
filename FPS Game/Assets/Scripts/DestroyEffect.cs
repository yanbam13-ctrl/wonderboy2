using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    //제거될 시간 변수
    public float destroyTime = 1.5f;

    private void Start()
    {
        //destroyTime만큼 시간이 흐른 후 오브젝트 제거
        Destroy(gameObject, destroyTime);        
    }
}
