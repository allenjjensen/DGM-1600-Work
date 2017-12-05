using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {

    public enum Type { fancyShot, Shield, SpeedBoosterAwesomePants};
    public Type powerUpType;
    public Sprite[] images;
    


	// Use this for initialization
	void Start () {
        switch (powerUpType)
        {
            case Type.fancyShot:
                gameObject.GetComponent<SpriteRenderer>().sprite = images[0]; 
                break;
            case Type.Shield:
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
        Debug.Log("We hit a powerup!");
        if (powerUpType == Type.SpeedBoosterAwesomePants) { }
       

        switch (powerUpType)
        {
            case Type.fancyShot:
                break;
            case Type.Shield:
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
