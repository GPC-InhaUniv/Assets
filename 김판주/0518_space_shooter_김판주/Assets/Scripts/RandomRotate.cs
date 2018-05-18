using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour {

    [Range(0,10)]
    public float tumble;

    void Start()
    {
        Rigidbody AsteroidRigidbody = GetComponent<Rigidbody>();

        AsteroidRigidbody.angularVelocity = Random.insideUnitSphere * tumble;

    }

}
