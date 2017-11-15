using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public GameObject projectile;
    public Transform shotPos;
    public float shotForce;
    public float moveSpeed;
    private Rigidbody2D rb;
    public float thrust;
    public ParticleSystem particles;
    
    



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }






    
    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.W)){
           
            particles.Emit(1);
        }
            

        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(new Vector3(h, v, 0f)); 
       

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
