using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class AddController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//x value
        float moveVertical = Input.GetAxis("Vertical");//z value

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);//공에 추가할 포스의 방향을 정한다

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            
        }
    }
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count>=13)
        {
            winText.text = "You Win";
        }
        

        }
 }