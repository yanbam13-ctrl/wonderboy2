using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    public int weaponPower = 10;
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (!c.gameObject.CompareTag("Monster")) return;

        print("Monster¶û °ËÀÌ¶û Ãæµ¹");

        EnemyFSM eFSM = c.gameObject.GetComponent<EnemyFSM>();

        eFSM.HitEnemy(weaponPower);

    }
}
