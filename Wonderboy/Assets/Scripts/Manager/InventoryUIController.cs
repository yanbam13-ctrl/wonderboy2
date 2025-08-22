using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIController : MonoBehaviour
{
    public ItemSlotUI itemSlot;

    void Start()
    {
        RefreshAll();
        print("SwordID : " + SaveInventory.SwordId);
    }

    public void RefreshAll()
    {
        // 예: 검 보유/종류를 저장소에서 읽어 결정
        // 종류가 여러 개면 SaveInventory.SwordId 같은 정수를 저장해두세요.

        int id = SaveInventory.SwordId; // -1이면 없음

        Sprite s = (id >= 0 && id < itemSlot.options.Count) ? itemSlot.options[id] : null;
        itemSlot.SetSprite(s);


    }

}
