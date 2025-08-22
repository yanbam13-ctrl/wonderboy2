using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    Image img;
    Sprite emptySprite;

    public List<Sprite> options = new List<Sprite>();

    void Awake()
    {
        if (!img) img = GetComponent<Image>();  // Image 자동 할당

        if (img && emptySprite == null)         // ② img가 존재하고, emptySprite가 비어 있다면
            emptySprite = img.sprite;           //    현재 Image에 들어있는 기본 스프라이트를 emptySprite로 복사
    }

    // 직접 스프라이트 지정
    public void SetSprite(Sprite s)
    {
        if (!img) return;
        if (s != null) { img.sprite = s; img.enabled = true; }
        else
        {
            if (emptySprite) { img.sprite = emptySprite; img.enabled = true; }
            else img.enabled = false;
        }
    }

    //인덱스로 지정 - inspector의 options 사용

    public void SetByIndex(int i)
    {
        if (i >= 0 && i < options.Count) SetSprite(options[i]);
        else SetSprite(null);
    }

}
