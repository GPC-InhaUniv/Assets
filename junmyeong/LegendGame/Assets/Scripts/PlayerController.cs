using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text WinText;
    public Text LoseText;

    private Rigidbody rb;
    private int count;
    private int lose;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        lose = 0;
        SetCountText();
        WinText.text = "";
        LoseText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up") && lose ==0)
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            if(count >= 12)
            {
                WinText.text = "You Win!!";
            }
        }
        else if (other.gameObject.CompareTag("False Up") && lose == 0 && count < 12)
        {
            other.gameObject.SetActive(false);
            lose++;
            if(lose == 1)
            LoseText.text = "You Lose...";
        }
    }

    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
    }
}
