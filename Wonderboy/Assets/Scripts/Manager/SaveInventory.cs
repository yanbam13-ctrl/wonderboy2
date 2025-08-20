using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveInventory 
{
    public static int Gold { get => PlayerPrefs.GetInt("Gold", 0); set { PlayerPrefs.SetInt("Gold", value); PlayerPrefs.Save(); } }
    public static bool Boots { get => SaveFlags.GetBool("Item_Boots"); set => SaveFlags.SetBool("Item_Boots", value); }
    public static bool Shield { get => SaveFlags.GetBool("Item_Shield"); set => SaveFlags.SetBool("Item_Shield", value); }
    public static bool Armor { get => SaveFlags.GetBool("Item_Armor"); set => SaveFlags.SetBool("Item_Armor", value); }
    public static bool Helmet { get => SaveFlags.GetBool("Item_Helmet"); set => SaveFlags.SetBool("Item_Helmet", value); }
    public static float HourglassRemain { get => PlayerPrefs.GetFloat("Item_Hourglass", 0f); set { PlayerPrefs.SetFloat("Item_Hourglass", value); PlayerPrefs.Save(); } }
}

