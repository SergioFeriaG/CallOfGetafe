using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyDamage : MonoBehaviour
{
    Enemy receiveDamage;
    [SerializeField]
    int lifeFinalEnemy;
    [SerializeField]
    GameObject hitFx;
    [SerializeField]
    GameObject deathFx;
    [SerializeField]
    GameObject finalScreen;

    public void TakeDamage(int damage, Vector3 point, Vector3 normal)
    {
        lifeFinalEnemy -= damage;

        if (lifeFinalEnemy<=0)
        {
            FinalEnemyDead();
            //finalScreen.SetActive(true);

        } else 
        {
            GameObject psDamage = Instantiate(hitFx, point, Quaternion.LookRotation(normal));
            psDamage.transform.SetParent(transform);
        }
    }
    public void FinalEnemyDead()
    {
        GameObject psDeath = Instantiate(deathFx, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
