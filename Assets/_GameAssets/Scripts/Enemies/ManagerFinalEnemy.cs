using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerFinalEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject finalEnemy;
    public void ActivateFinalEnemy()
    {
        finalEnemy.SetActive(true);
    }
}
