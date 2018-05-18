using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public float Tumble;
    private Rigidbody Rb;
	// Use this for initialization
	void Start () {
        Rb=GetComponent<Rigidbody>();
        Rb.angularVelocity = Random.insideUnitSphere * Tumble;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
