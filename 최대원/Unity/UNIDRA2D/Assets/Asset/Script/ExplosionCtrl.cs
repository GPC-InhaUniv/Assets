using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour {

    private void Start()
    {
        Invoke("die", 0.99f);
    }

    void die()
    {
        Destroy(gameObject);
    }
}
