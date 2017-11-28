using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public GameObject explosionEffect;


    public void IncrementHealth(int HealthValue)
    {
        health += HealthValue;
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }
    }

	
}
