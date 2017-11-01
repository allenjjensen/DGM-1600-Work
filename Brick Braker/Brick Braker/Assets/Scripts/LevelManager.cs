using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static int brickCount;


    private void Start(){
        brickCount = FindObjectsOfType<HP>().Length;
        print(brickCount);
        
    
    }



    public void LevelLoad(string lvl) {
        SceneManager.LoadScene(lvl);

   

    }

    public void ExitGame (){
        print("Exit Game.");
        Application.Quit ();
    }
    public void LoadNextLevel(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CheckBrickCount (){
       
        if(brickCount <= 0) {
            LoadNextLevel();
                }
    }
}
