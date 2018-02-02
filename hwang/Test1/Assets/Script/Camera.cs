using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {


    public GameObject _Player;
    public GameObject _Camera;
    public Vector3 _CameraPosition;

	// Use this for initialization
	void Start () {
        _CameraPosition = _Camera.transform.position - _Player.transform.position;

    }
	
	// Update is called once per frame
	void LateUpdate () {
        _Camera.transform.position = _Player.transform.position + _CameraPosition;
	}
}
