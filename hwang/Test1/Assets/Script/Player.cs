using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour {

    public Text ScoreText;
    public Text WinText;

    private Rigidbody Rb;

    public int Score;

    public float Speed;


	// Use this for initialization
	void Start () {
        Rb = GetComponent<Rigidbody>();
        Score = 0;

        setScoreText();
        WinText.text = "";


    }

    // Update is called once per frame
    void Update () {
		
	}

    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);

        Rb.AddForce(Movement * Speed);


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {

            other.gameObject.SetActive(false);
            Score += 1;

            setScoreText();
        }
    }

    void setScoreText()
    {
        ScoreText.text = "Score:" + Score.ToString();

        if (Score >= 12)
        {
            WinText.text = "You Win!!";

        }
    }
}
