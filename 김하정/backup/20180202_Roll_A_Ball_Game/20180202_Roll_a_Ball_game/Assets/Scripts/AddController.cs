using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//x value
        float moveVertical = Input.GetAxis("Vertical");//z value

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);//공에 추가할 포스의 방향을 정한다

        rb.AddForce(movement * speed);
            
            
            }
}
