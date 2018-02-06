using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCotroller : MonoBehaviour {

    public int speed;
    private Rigidbody2D rb2d;
    private int count;
    public Text Count_text;
    public Text Win_text;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        setCountText();
        Win_text.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count++;
            setCountText();
            if(count >= 12)
            {
                Win_text.text = "You Win!!!!@";
            }
        }
    }

    void setCountText()
    {
        Count_text.text = "Count = " + count.ToString();
    }

}
