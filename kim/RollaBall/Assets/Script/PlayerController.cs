using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public float dfSpeed;
    private float speed;
    public Text countText;
   
    private Rigidbody rb;
    private int count;
    public float overTime;

    private void Start()
    {
        speed = dfSpeed;
        rb = GetComponent<Rigidbody>();
        count = 0;
       
       
        overTime = 0;
    }

    // Update is called once per frame
    void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
           
           
        }
    }

    

    private void Update()
    {
        countText.text = "count: " + count.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = dfSpeed * 2;
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            speed = dfSpeed;
        }
    }
}
