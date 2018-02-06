using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - Player.transform.position;
        Debug.Log("start offset : " + offset);
    }

     void LateUpdate ()
    {
        Debug.Log("offset : " + offset);
     
        transform.position = Player.transform.position + offset;

    }
}