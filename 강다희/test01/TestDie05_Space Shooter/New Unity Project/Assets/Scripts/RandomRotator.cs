using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float Tumble;
    public Rigidbody rb;

    private void Start()
    {
        rb.angularVelocity = Random.insideUnitSphere * Tumble;
    }
}