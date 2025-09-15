using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text KillText;
    public int killCount;

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    private void Start()
    {
        KillText.text = killCount.ToString();
    }

    public void UpdateKillCount()
    {
        KillText.text = killCount.ToString();
    }


}
