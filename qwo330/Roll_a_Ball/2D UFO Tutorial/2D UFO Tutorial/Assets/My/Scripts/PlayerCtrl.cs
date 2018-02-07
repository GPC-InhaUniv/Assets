using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCtrl : MonoBehaviour {

    public float speed = 10;
    public Text countText;
    public Text winText;

    Rigidbody2D rigid;
    float Horizontal = 0.0f;
    float Vertical = 0.0f;
    int count;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(Horizontal, Vertical);
        rigid.AddForce(movement * speed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count : " + count.ToString();
        if (count >= 12) winText.text = "You Win!";
    }
}
