using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartFinalEnemy : MonoBehaviour 
{
    [Range(1,50)]
    public float followDistance;
    public float distanceToPlayer;
    public GameObject player;
    public float speed;
    public Animator animator;
    [SerializeField]
    bool follow;
    public static SmartFinalEnemy smartFinalEnemy;

    //Variables de clase para FinalEnemyDamage

    /*public int maxHealth;
    public int health;
    public GameObject prefabPSDamage;
    public GameObject prefabPSDeath;
    
    [SerializeField]
    int lifeAmount;
    [SerializeField]
    HealthManager healthManager;
    [Range(0,5)]
    public float distanceToExplosion;*/

    private void Awake() 
    {
        smartFinalEnemy = this;
        player = GameObject.FindGameObjectWithTag("Player");
        //health = maxHealth; //Codigo Damage
        //healthManager = FindObjectOfType<HealthManager>();//Codigo Damage
    }

    public void FinalEnemyActivator()
    {
        follow = true;
    }

    private void Update() 
    {
        if(follow)
        {
            distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
            Vector3 target = new Vector3(player.transform.position.x, transform.position.y ,player.transform.position.z);
            transform.LookAt(target);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            
            if (distanceToPlayer <= 5)
            {
                animator.GetComponent<Animator>().SetTrigger("Attack");
                follow = false;
            }
        }
    }
    
    public void Rotate()
    {
        if (distanceToPlayer <= followDistance) return;
        int determinante = Random.Range(0, 100);
        int signo = determinante > 50 ? 1 : -1;
    }

    //Codigo para FinalEnemy Damage
    /*public void ReceiveDamage(int damage, Vector3 impactPosition, Vector3 normal)
    {
        health-=damage;
        if (health<=0){
            Death();
        } else {
            GameObject psDamage = Instantiate(prefabPSDamage, impactPosition, Quaternion.LookRotation(normal));
            psDamage.transform.SetParent(transform);
        }
    }
    public void Death()
    {
        GameObject psDeath = Instantiate(prefabPSDeath, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    public void Attack()
    {
        if (distanceToPlayer <= distanceToExplosion)
        {
            healthManager.RemoveLife(lifeAmount);
            Instantiate(prefabPSDeath, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }*/
}