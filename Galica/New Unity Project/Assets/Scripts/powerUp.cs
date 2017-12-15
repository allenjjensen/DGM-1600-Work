using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {

    public enum Type { HpUp, SpeedBoosterAwesomePants};
    public Type powerUpType;
    public Sprite[] images;
    


	// Use this for initialization
	void Start () {
        switch (powerUpType)
        {
            
            case Type.HpUp:
                break;
            case Type.SpeedBoosterAwesomePants:
                break;
            default:
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) { 
        if (powerUpType == Type.SpeedBoosterAwesomePants) { }
        if(powerUpType == Type.HpUp) { }
       

        switch (powerUpType)
        {
            case Type.HpUp:
                other.gameObject.GetComponent<Health>().IncrementHealth(+1);
                break;
            case Type.SpeedBoosterAwesomePants:
                other.GetComponent<playerController> ().speed *= 2;
                break;
            default:
                break;
        }
        
            Destroy(this.gameObject);
        }

    

}
