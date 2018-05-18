using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    Vector2 angle;
    Rigidbody2D fireRigidbody;

    private void Start()
    {
        angle = (Vector2)transform.rotation.eulerAngles;
        fireRigidbody = GetComponent<Rigidbody2D>();
        fireRigidbody.AddForce(angle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Fire")
        {
            Destroy(gameObject);
        }
    }
}
