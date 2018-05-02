using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderController : MonoBehaviour {

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire"||collision.gameObject.tag=="Field"||collision.gameObject.tag=="Player"||collision.gameObject.tag=="Item")
        Destroy(gameObject);
    }
}
