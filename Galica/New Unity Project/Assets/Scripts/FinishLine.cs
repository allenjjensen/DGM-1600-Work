using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour {

    public LevelManager myLevelManager;






    private void OnTriggerEnter2D(Collider2D trigger)
    {
        myLevelManager.LevelLoad("Winner");
        { 


        }
    }
}
