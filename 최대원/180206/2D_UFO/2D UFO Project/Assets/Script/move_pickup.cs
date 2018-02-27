using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_pickup : MonoBehaviour {

    public float speedX;
    public float speedY;

    private float speedR;

    // Use this for initialization
    void Start () {
        speedR = Random.value - 0.5f;
        speedX = speedX * speedR;
        speedY = speedY * speedR;
    }
	
	// Update is called once per frame
	void Update () {
        movecontrol();
    }

    void movecontrol()
    {
        this.transform.Translate(speedX, speedY, 0);
    }
}
