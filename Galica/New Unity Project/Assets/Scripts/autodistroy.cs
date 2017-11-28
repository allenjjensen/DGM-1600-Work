using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodistroy : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Destroy (gameObject, GetComponent<ParticleSystem>().duration);
	}
	
	
}
