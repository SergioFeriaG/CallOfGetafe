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

    private void Awake() 
    {
        smartFinalEnemy = this;
        player = GameObject.FindGameObjectWithTag("Player");    
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
                //animator.GetComponent<Animator>().SetBool("Walk", false);
                animator.GetComponent<Animator>().SetTrigger("Attack");
                follow = false;
                //animator.SetTrigger("Attack");
            }
        }
    }
    
    public void Rotate()
    {
        if (distanceToPlayer <= followDistance) return;
        int determinante = Random.Range(0, 100);
        int signo = determinante > 50 ? 1 : -1;
    }


}