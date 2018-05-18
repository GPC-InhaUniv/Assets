using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    private Rigidbody Rb;
    public float speed;
	void Start () {
        Rb = GetComponent<Rigidbody>();
        Rb.velocity = transform.up * speed;

    }

}
