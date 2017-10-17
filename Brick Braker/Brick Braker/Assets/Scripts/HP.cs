using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int health;


    void OnCollisionEnter2D(Collision2D collision){

        health--;

        if ( health <= 0) { Destroy(this.gameObject);
        }

        }


    }
	
	
    
        
		
	

