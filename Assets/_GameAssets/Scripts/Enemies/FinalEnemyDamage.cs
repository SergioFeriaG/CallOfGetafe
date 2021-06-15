using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyDamage : MonoBehaviour
{
    Enemy receiveDamage;

    private void Awake() 
    {
        receiveDamage = FindObjectOfType<Enemy>();    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EnemyDamage()
    {
        //receiveDamage.ReceiveDamage();
    }
}
