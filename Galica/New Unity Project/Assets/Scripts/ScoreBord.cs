﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBord : MonoBehaviour {

    public int score;
    public Text display;
    public Text highscoreDisplay;
    public Text prevScoreDisplay;
    

	// Use this for initialization
	void Start () {
        score = 0;
        if (display != null)
        {
            display.text = score.ToString();
        }

       if (highscoreDisplay != null)
           highscoreDisplay.text = GetScore().ToString();
        if (prevScoreDisplay != null)
            prevScoreDisplay.text = PlayerPrefs.GetInt("PrevScore").ToString();

	}
	
    public void IncrementScoreboard(int value)
    {
        score += value;
        display.text = score.ToString();

    }


    public void SaveScore()
    {
        int oldScore = GetScore();
        PlayerPrefs.SetInt("PrevScore", score);

        if (score > oldScore)
            PlayerPrefs.SetInt("HighScore", score);
    }


    public int GetScore()
    {
        return PlayerPrefs.GetInt("HighScore");

    }

    public void OnDisable()
    {
        SaveScore();
    }


}
