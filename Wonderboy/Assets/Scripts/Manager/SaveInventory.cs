using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveInventory 
{
    public static int SwordId
    {
        get => PlayerPrefs.GetInt("SwordId", -1);
        set { PlayerPrefs.SetInt("SwordId", value); PlayerPrefs.Save(); }
    }

    // (선택) 여러 종류를 “소유”할 수 있고 그 중 하나만 장착한다면:
    public static bool IsOwned(string itemId) => SaveFlags.GetBool($"Owned_{itemId}");
    public static void SetOwned(string itemId, bool owned) => SaveFlags.SetBool($"Owned_{itemId}", owned);


    public static int Gold { get => PlayerPrefs.GetInt("Gold", 0); set { PlayerPrefs.SetInt("Gold", value); PlayerPrefs.Save(); } }
    public static bool Boots { get => SaveFlags.GetBool("Item_Boots"); set => SaveFlags.SetBool("Item_Boots", value); }
    public static bool Shield { get => SaveFlags.GetBool("Item_Shield"); set => SaveFlags.SetBool("Item_Shield", value); }
    public static bool Armor { get => SaveFlags.GetBool("Item_Armor"); set => SaveFlags.SetBool("Item_Armor", value); }
    public static bool Helmet { get => SaveFlags.GetBool("Item_Helmet"); set => SaveFlags.SetBool("Item_Helmet", value); }
    public static float HourglassRemain { get => PlayerPrefs.GetFloat("Item_Hourglass", 0f); set { PlayerPrefs.SetFloat("Item_Hourglass", value); PlayerPrefs.Save(); } }
}

