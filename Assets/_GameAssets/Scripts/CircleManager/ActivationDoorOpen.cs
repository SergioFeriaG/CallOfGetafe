using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationDoorOpen : MonoBehaviour
{
    //Opci�n 1.
    public Animator animator;
    private AudioSource audioSource;
    public AudioClip deepHorn;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();    
    }
    
    private void OnCollisionEnter(Collision other) {

        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Entro");
            animator.SetBool("Open", true);
            
            if (!audioSource.isPlaying){
                PlayHornSound();
                Destroy(gameObject);
            }
            else
            {
                return;
            }
        }
    }
    private void PlayHornSound()
    {
        audioSource.PlayOneShot(deepHorn);
    }
    //OpciÛn 2.
    /*
    private Animator animatorPuerta;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animatorPuerta = GameObject.Find("Door").GetComponent<Animator>();
            animatorPuerta.enabled = true;
        }
    }
    */
}
