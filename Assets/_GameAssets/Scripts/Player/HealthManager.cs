using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] 
    int playerLife;
    [SerializeField] 
    int maxLife;
    [SerializeField]
    GameObject gameOverPanel;
    [SerializeField]
    Text textLife;
    [SerializeField]
    GameObject animatorLight;
    

    void Start() 
    {
        textLife.text = playerLife.ToString();
    }
    public void AddLife(int lifeCatch)
    {
        playerLife =+ lifeCatch;
        if(playerLife > maxLife)
        {
            playerLife = maxLife;
        }
        if(playerLife == 100)
        {
            animatorLight.GetComponent<Animator>().SetBool("On", false);
        }
        textLife.text = playerLife.ToString();
    }
    public void RemoveLife(int damage)
    {
        playerLife -= damage;

        if(playerLife == 10)
        {
            animatorLight.GetComponent<Animator>().SetBool("On", true);
        }

        if(playerLife<= 0)
        {
            playerLife = 0;
            ActivateGameOverPanel();
        }
        textLife.text = playerLife.ToString();
    }
    void ActivateGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        //TimeScale = 0f;
    }


}
