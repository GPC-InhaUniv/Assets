using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerComtroller : MonoBehaviour {


    public float speed;
    public Text scoreText;
    public Text WinText;

    private Rigidbody rb;
    private int score;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        WinText.text = "";
    }

    //프레임을 렌더링 하기 전에 호출
    private void Update()
    {
        
    }

    //물리 효과를 계산하기 전에 호출
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Score : " + score.ToString();
        if (score >= 11)
        {
            WinText.text = "You Win!";
        }
    }
}
