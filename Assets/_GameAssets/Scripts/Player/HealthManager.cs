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
        textLife.text = playerLife.ToString();
    }
    public void RemoveLife(int damage)
    {
        playerLife -= damage;
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
    }


}
