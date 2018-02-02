using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Vector3 Coin;

	// Use this for initialization
	void Start () {
        Coin = new Vector3(15, 30, 45);

    }
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Coin * Time.deltaTime);
		
	}
}
