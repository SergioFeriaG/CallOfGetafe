using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverRemovingLife : MonoBehaviour
{
    [SerializeField]
    int lifeAmount;
    [SerializeField]
    HealthManager healthManager;
    //[SerializeField]
    //MobileEnemy movileEnemy;

    private void Awake() 
    {
        healthManager = FindObjectOfType<HealthManager>();
        //movileEnemy = FindObjectOfType<MobileEnemy>();    
    }
    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            healthManager.RemoveLife(lifeAmount);
        }
    }
}
