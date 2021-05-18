using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FootSteps : MonoBehaviour
{
    FirstPersonController firstPersonController;

    void Start(){

        firstPersonController = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
    }

    private void OnTriggerStay(Collider other) {
        firstPersonController.SetFootZone(FirstPersonController.TipoSuelo.Wood);
    }
    private void OnTriggerExit(Collider other){
        firstPersonController.SetFootZone(FirstPersonController.TipoSuelo.Normal);
    }
}
