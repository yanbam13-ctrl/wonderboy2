using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject swordIdle;
    public GameObject swordJump;
    public bool isJump = false;

    private void Start()
    {
        Apply();
    }

    void Apply()
    {
        bool hasSword = SaveInventory.SwordId >= 0;

        if (!hasSword)
        {
            if (swordIdle) swordIdle.SetActive(false);
            if (swordJump) swordJump.SetActive(false);
            return;
        }

        if (swordIdle) swordIdle.SetActive(!isJump);
        if (swordJump) swordJump.SetActive(isJump);
    }


    public void SwordStateJump(bool on)
    {
        isJump = on;
        Apply();
    }


}
