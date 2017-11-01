using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {




    private void Start() {
        
    }



    public void LevelLoad(string lvl) {
        SceneManager.LoadScene(lvl);

    }

    public void ExitGame (){   // dont have this in a mobal game
        Application.Quit ();
    }
    public void LoadNextLevel(){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
}

 
       
       
  
