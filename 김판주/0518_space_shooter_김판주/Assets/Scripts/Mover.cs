using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    [Range(-5,30)]
    public float speed;

    private void Start()
    {
        Rigidbody rigidbodyBolt = GetComponent<Rigidbody>();

        rigidbodyBolt.velocity = transform.forward * speed;
    }
}
