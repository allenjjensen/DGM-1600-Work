using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public GameObject explosionEffect;
    public GameObject[] hearts;
    private GameObject scoreboard;
    

    private void Start()
    {
        scoreboard = FindObjectOfType<ScoreBord>().gameObject;
        if (MePlayer())
        {
            ShowHearts();
            
        }
    }

    // seeing if what this script is on is the playerController
    private bool MePlayer()
    {
        if (GetComponent<playerController>())
        {
            return true;
        } else
        {
            return false;
        }

    }

    // destroys itself on 0 hp
    public void IncrementHealth(int HealthValue)
    {
        health += HealthValue;
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
          if (!MePlayer())
            {
                IncrementScore();
            }
            
          if (MePlayer())
          {
           gameObject.GetComponent<playerController>().levelManager.GetComponent<LevelManager>().LoadNextLevel();
          }
            
        }
        ShowHearts();
    }


    private void ShowHearts()
    {
        // turns all hearts off
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(false);
        }
        // turns hearts on by health 
        for (int i = 0; i < health; i++)
        {

            hearts[i].SetActive(true);
        }
    }

  private void IncrementScore()
    {
        scoreboard.GetComponent<ScoreBord>().IncrementScoreboard(10);
    }

    public int GetHealth()
    {
        return health;

    }
	
}
