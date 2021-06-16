using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GameScene()
    {
        //Time.timeScale = 1.0f;
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    /*public void Credits()
    {
        SceneManager.LoadScene(3);
    } */
}
