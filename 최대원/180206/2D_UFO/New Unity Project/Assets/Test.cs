using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    float rotate;

    private void Start()
    {
        rotate = 0;
    }

    private void Update()
    {
        rotate += Time.deltaTime * 360.0f;
        transform.rotation = Quaternion.Euler(rotate*5, rotate*2, rotate*5);
    }
}
