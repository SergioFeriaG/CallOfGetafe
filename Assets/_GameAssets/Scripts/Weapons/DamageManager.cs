using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter(Collision other) 
    {
        if (IsEnemy(other.gameObject))
        {
            Destroy(gameObject);
            other.gameObject.GetComponentInParent<Enemy>().ReceiveDamage(damage, other.GetContact(0).point, other.GetContact(0).normal);
        }
        else if (IsFinalEnemy(other.gameObject))
        {
            other.gameObject.GetComponentInParent<FinalEnemyDamage>().TakeDamage(damage, other.GetContact(0).point, other.GetContact(0).normal);
            Destroy(gameObject);
        }
    }
    private bool IsEnemy(GameObject candidate){
        return (candidate.CompareTag("Enemy"));
    }
    private bool IsFinalEnemy(GameObject candidate){
        return (candidate.CompareTag("FinalEnemy"));
    }
}