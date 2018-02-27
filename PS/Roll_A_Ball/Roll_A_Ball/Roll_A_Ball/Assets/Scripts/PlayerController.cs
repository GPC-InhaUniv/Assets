using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {     // 상속

    public float speed;
    public Text countText;
    public Text winText; 

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        
        SetCountText ();
        winText.text = "";
    }

    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");         // 키보드 입력 파악
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))     // 태그를 스트링 값과 비교
        {
            other.gameObject.SetActive(false);      // 게임오브젝트를 활성화하거나 비활성화함
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
