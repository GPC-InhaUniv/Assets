using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float Speed;
    
	// Use this for initialization
	void Start () {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = transform.forward * Speed;

    }
	
	 
}
