using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    bool activeHit;
    [SerializeField]
    int damage;

    private void OnEnable() 
    {
        activeHit = true;
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("Player") && activeHit)
        {
            activeHit = false;
            FindObjectOfType<HealthManager>().RemoveLife(damage);
        }
    }
}
