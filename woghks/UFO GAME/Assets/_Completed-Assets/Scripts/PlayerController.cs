using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject jem;
    public GameObject PickUp;
    public Text countText;
    public Text winText;


    private Rigidbody2D rb2d;
    private int count;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 1;
        Instantiate(jem, new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
        Instantiate(PickUp, new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)), Quaternion.identity);
        SetCountText ();
        winText.text = "";
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText ();
        }
    }
        void SetCountText()
        { 
            countText.text = "Count : " + count.ToString ();
            if (count >= 0)
            winText.text = "You win!!";
        }
}
