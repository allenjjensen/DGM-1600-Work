using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;
    public float speed;
    private Rigidbody2D rb;
    public float thrust;
    public ParticleSystem particles;
    private Rigidbody2D rigid;
    public GameObject levelManager;






    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        print(GetComponent<Health>().GetHealth());
    }



    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

       // rb.AddForce(movement * speed);
        rb.AddRelativeForce(movement * speed);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        coll.gameObject.GetComponent<Health>().IncrementHealth(-1);

    }

    // Update is called once per frame
    void Update () {


          if (Input.GetKey(KeyCode.W)){
           
           particles.Emit(1);
        }
            

     
       

        if (Input.GetButtonUp("Fire1"))
        {
            GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
            shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
            
            
        }

        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg -90f;
        transform.rotation = Quaternion.AngleAxis(angle, (Vector3.forward) );
        //transform.rotation.z -= 90f;
        


    }
}
