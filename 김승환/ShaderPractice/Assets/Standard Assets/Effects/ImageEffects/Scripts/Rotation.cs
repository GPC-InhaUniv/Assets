using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    float y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        y += Time.deltaTime * 20;
        transform.rotation = Quaternion.Euler(-90, y, 0);
    }
}
