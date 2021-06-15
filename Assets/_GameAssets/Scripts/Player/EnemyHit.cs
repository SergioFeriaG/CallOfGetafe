using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    bool activeHit;
    [SerializeField]
    int damage;
    public AudioClip slap;
    private AudioSource audioSource;

    private void Start() 
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable() 
    {
        activeHit = true;
    }

    private void OnTriggerStay(Collider other) 
    {
        if(other.gameObject.CompareTag("Player") && activeHit)
        {
            FindObjectOfType<HealthManager>().RemoveLife(damage);
            audioSource.PlayOneShot(slap);
            activeHit = false;
        }
    }
}
