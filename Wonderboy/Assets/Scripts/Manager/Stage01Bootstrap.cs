using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01Bootstrap : MonoBehaviour
{
    void Start()
    {
        // 문 옆 벽돌 애니메이터 켜기
        if (SaveFlags.GetBool(SaveFlags.Stage01_BrickBounce))
        {
            //  비활성 오브젝트까지 포함해서 찾기
            foreach (var b in FindObjectsOfType<BrickBounce>(true))
            {
                b.gameObject.SetActive(true);
                b.EnableBounce(true);
            }
        }

    }


}
