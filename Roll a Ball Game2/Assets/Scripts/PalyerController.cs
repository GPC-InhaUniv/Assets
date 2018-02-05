using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PalyerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

   void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCOuntText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    //트리거 콜라이더를 접촉할 때마다 이 코드가 호출
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"));
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCOuntText();
        }
    }

    void SetCOuntText()
    {
        countText.text = "Count : " + count.ToString();
        if(count >= 13)
        {
            winText.text = "You Win!";
        }
    }
}