using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
    public float startingSpin;

    public int health;
    public Sprite[] picture;
    private int count = 0;
    private LevelManager levelManager;
    


    void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-startingSpin, startingSpin), ForceMode2D.Impulse);
        levelManager = FindObjectOfType<LevelManager>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        health--;
        count++;
        if (count > picture.Length - 1)
        {
            count--;
        }
        if (health <= 0){
          Destroy(this.gameObject);

        }

    }


}