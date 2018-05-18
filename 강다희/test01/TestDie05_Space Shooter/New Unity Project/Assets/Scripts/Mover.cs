using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float speed;

    private void Start()
    {
        rigidbody.velocity = transform.forward * speed;
    }
}