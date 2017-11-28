using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour


	{
    public GameObject shipLaser; 
    public float lifetime;
    public float Speed;
    public int damage;
    public AudioSource audio;



    // Use this for initialization
    void Start()
    {
        ///audio.pitch = Random.Range(1f, 1.5f);

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
        Destroy(gameObject);
        
    }
}