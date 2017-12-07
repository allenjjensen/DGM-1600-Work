using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public static int health;


    private void Start()
    {
        health = FindObjectsOfType<Health>().Length;
        print(health);


    }




    public void LevelLoad(string lvl01)
    {
        SceneManager.LoadScene(lvl01);

    }

    public void ExitGame()
    {   // dont have this in a mobal game
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HeartCount()
    {

        if (health <= 0)
        {
            LoadNextLevel();
        }
    }
}

 
       
       
  
