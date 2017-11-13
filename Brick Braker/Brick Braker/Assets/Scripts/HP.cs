using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
    
    public int health;
    public Sprite[] picture;
    private int count = 0;
    private LevelManager levelManager;

    private void Start(){
       levelManager = FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collider){

        health--;
        count++;
        if (count > picture.Length -1) {
            count--;
        }
        GetComponent <SpriteRenderer>().sprite = picture[count];
        if ( health <= 0) {
            LevelManager.brickCount--;
            levelManager.CheckBrickCount();
            Destroy(this.gameObject);
        }

        }


    }
	
	
    
        
		
	

