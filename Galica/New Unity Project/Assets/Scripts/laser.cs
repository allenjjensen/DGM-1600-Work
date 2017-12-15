using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour


	{
    public GameObject shipLaser; 
    public float lifetime;
    public float Speed;
    public int damage;
    



    // Use this for initialization
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other){
        other.GetComponent<Health>().IncrementHealth(damage);
        Destroy(this.gameObject);

    }
}