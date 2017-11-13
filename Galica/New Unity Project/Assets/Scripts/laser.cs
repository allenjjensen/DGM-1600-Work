using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour


	{
    public GameObject shipLaser; 
    public float lifetime;
    public float Speed;



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
            Destroy(this.shipLaser);
        }
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }
}