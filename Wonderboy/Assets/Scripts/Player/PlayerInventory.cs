using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject swordIdle;
    public GameObject swordJump;
    public GameObject swordAttack;
    public bool isJump = false;
    public bool isAttack = false;

    private void Start()
    {
        Apply();
    }

    void Apply()
    {
        bool hasSword = SaveInventory.SwordId >= 0;

        // 기본은 전부 끄고 시작
        if (swordIdle) swordIdle.SetActive(false);
        if (swordJump) swordJump.SetActive(false);
        if (swordAttack) swordAttack.SetActive(false);

        if (!hasSword) return;

        if (isAttack)
        {
            if (swordAttack) swordAttack.SetActive(true);
        }
        else if (isJump)
        {
            if (swordJump) swordJump.SetActive(true);
        }
        else
        {
            if (swordIdle) swordIdle.SetActive(true);
        }
    }

    // 애니메이션 이벤트/상태 전환에서 호출
    public void AttackStart()
    {
        isAttack = true; 
        Apply();
    }
    public void AttackEnd()
    {
        isAttack = false; 
        Apply();
    }

    public void SwordStateJump(bool on)
    {
        isJump = on;
        Apply();
    }


}
