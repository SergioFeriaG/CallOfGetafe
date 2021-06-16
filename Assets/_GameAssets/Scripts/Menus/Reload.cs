using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Reload : MonoBehaviour
{
    private void Start() 
    {
        
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Boton");
    }
}
