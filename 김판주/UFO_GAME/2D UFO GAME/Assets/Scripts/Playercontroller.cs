using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text WinText;


    private Rigidbody2D rb2d;
    private int count;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        WinText.text = "";
        SetCountText();


    }
    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(MoveHorizontal, MoveVertical);
        rb2d.AddForce(movement * speed);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }
    }
    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
        if (count >= 12)
        {
            WinText.text = "You win!";
        }
    }
}