using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject enemyBulletFactory;
    public float fireRate;

    private void OnEnable()
    {
        StartCoroutine(Fire());
    }

    IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireRate);

            // ÃÑ¾Ë ¹ß»ç
            Instantiate(
                enemyBulletFactory,
                transform.position,
                Quaternion.Euler(180f, 0, 0));
        }
    }
}
