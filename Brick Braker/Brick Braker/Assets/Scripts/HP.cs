using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
    public int health;

	// Use this for initialization
	void Start () {

    void OnCollisionEnter(Collision collision){
            if (collision.relativeVelocity.magnitude >=1)
                health - 1 ();
        }


    }
	
	// Update is called once per frame
	void Update () {
    
        
		
	}
}
