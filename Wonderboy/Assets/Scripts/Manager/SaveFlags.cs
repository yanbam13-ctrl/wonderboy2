using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveFlags
{
    public static bool GetBool(string key, bool def = false) => PlayerPrefs.GetInt(key, def ? 1 : 0) == 1;
    public static void SetBool(string key, bool v) { PlayerPrefs.SetInt(key, v ? 1 : 0); PlayerPrefs.Save(); }

    public const string HasSword = "HasSword";
    public const string Stage01_BrickBounce = "Stage01_BrickBounce";
}
