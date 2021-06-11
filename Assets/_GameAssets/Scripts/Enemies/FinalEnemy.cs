using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemy : MonoBehaviour
{
    public Animator animator;
    private void Start() 
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Walk", true);
            SmartFinalEnemy.smartFinalEnemy.FinalEnemyActivator();
        }
    }
}
