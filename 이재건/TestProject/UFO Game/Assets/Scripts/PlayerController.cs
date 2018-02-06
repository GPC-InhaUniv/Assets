using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;//이동 속도 조절
    public Text countText;
    public Text WinText;

    private Rigidbody2D rb; //강체 변수 rb 를 생성
    private int count;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();  //rb 변수에 getcompoenet를 통하여 rigidbody2d의 대한 요소를 넣어준다.
        speed = 10;
        count = 0;
        WinText.text = "";
        SetText();

    }
    void FixedUpdate()
    {
        float moveHoriziontal = Input.GetAxis("Horizontal");//수평 방향의 방향키 (<- ,->) 입력값을 move변수에 저장
        float moveVertical = Input.GetAxis("Vertical"); //수직 방향의 방향키 위아래 입력값을 moveverticla 에 저장


        Vector2 movement = new Vector2(moveHoriziontal, moveVertical);  //방향키를 입력받아 크기와 방향을 저장할 새로운 2차원 벡터

        rb.AddForce(movement * speed);  //rb라는 강체에 새로운 2차원 벡터의 정보를 대입함으로써 rb 강체에 물리력을 넣어준다.
        if (speed >= 10)
            speed -= 0.1f;  //player 속도 조절
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count++;
            SetText();
            if (count>=14)
            {
                WinText.text = "You Win!!";
            }
        }
        else if (collision.gameObject.CompareTag("Speed"))
        {
            speed += 15;  //speed 값 증가
            Debug.Log("스피드 업!"); //debug 체크를 위한 message
        }


    }

    void SetText()
    {
        countText.text = "Score :" + count.ToString();
    }
}
