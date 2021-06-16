using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
    [SerializeField]
    //int ammoAcount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Weapon weapon = FindObjectOfType<Weapon>();
            //weapon.GetAmmo(ammoAcount);
            Destroy(gameObject);
        }
    }
}
