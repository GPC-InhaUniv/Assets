using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositon : MonoBehaviour {

    public Vector3 dfpositon;
    public GameObject player;
	// Use this for initialization
	void Start () {
        dfpositon = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
       
    }
  
    private void OnTriggerStay(Collider other)
    {
        player.transform.position = dfpositon;


    }
}
