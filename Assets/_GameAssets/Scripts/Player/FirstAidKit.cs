using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : MonoBehaviour
{
    [SerializeField]
    int lifeAmount;
    [SerializeField]
    HealthManager healthManager;

    private void Awake() 
    {
        healthManager = FindObjectOfType<HealthManager>();    
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            healthManager.AddLife(lifeAmount);
        }
    }
}
