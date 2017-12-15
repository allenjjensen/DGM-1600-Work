using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
    public float startingSpin;

    
    
   
    private LevelManager levelManager;
    


    void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-startingSpin, startingSpin), ForceMode2D.Impulse);
        levelManager = FindObjectOfType<LevelManager>();
    }


    private void OnCollisionEnter2D(Collision2D coll)
    {
        coll.gameObject.GetComponent<Health>().IncrementHealth(-1);
   
       
 
        
    }
    

}


