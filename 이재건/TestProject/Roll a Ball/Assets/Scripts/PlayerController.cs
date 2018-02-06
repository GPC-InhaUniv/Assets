using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;   //속도를 조절하기 위한 변수값으로 손쉽게 조절 할 수 있도록 public으로 사용

    private Rigidbody rb;  //물리제어 class 로 객체 rb를 생성

    private int count;  //점수를 위한 변수
    private float JumpForce; //점프를 위한 변수
    bool checkGameOver; //gameover를 위한 bool값
    public Text countText; //점수를 출력하기 위한 text class
    public Text WinText;  //종료 ui를 위한 text class

    void Start()
    {
        rb = GetComponent<Rigidbody>();  //rigidbody에 대한 정보를 rb에 저장시켜 준다 . 프로그램이 시작되면.
        count = 0;  //점수는 0점으로 초기화
        JumpForce = 0;
        checkGameOver = false;
        SetCountText();
        WinText.text = " ";
    }

    void Update()
    {
        if (checkGameOver) //update 때마다 모든 것을 검사할 필요가 없으므로 if문으로 검사
        {
            if (this.transform.position.y <= -20)   //공이 맵을 벗어나 계속적으로 추락하고 있다면
            {
                WinText.text = "You Lose...";   //메세지를 바꾸어주며
                this.gameObject.SetActive(false);   //공을 비활성화 시킨다.
                SetCountText(); //업데이트 된 텍스트를 출력하기 위하여 함수를 다시 호출한다.
            }
        }
       
    }
 
  
    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");  //float value for move player  right or left
        float moveVertical = Input.GetAxis("Vertical");      //float value for move player  up   or down

        Vector3 movement = new Vector3(moveHorizontal,JumpForce, moveVertical);   //x,y,z vetor  x: right or left
                                                                              //y : not use , z: up or down

        rb.AddForce(movement*speed);   //물리력은 키보드로 입력받은 방향 * 속도 변수값       
        if(JumpForce>0)
            JumpForce -= 0.3f;  //object의 y가 무한정 증가하는것을 막기 위한 if문
        if (speed >= 10)
            speed -= 0.1f;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))  //만일 충돌한 object가 pick up 이라는 이름을 갖는다면
        {
            other.gameObject.SetActive(false);  //충돌한 object를 비활성화 시킨다.
            count++;                            //충돌시 점수 획득
            SetCountText();
        }
        else if(other.gameObject.CompareTag("Jump"))  //만일 jump와 충돌하였다면
        {
            JumpForce = 5.0f;  //jump값 증가.
            checkGameOver = true; //game 종료를 검사하는 버튼 on
            Debug.Log("점프!"); //debug 체크를 위한 message
          
        }
        else if(other.gameObject.CompareTag("Speed"))
        {
            speed += 15;  //speed 값 증가
            Debug.Log("스피드 업!"); //debug 체크를 위한 message
        }
        else if(checkGameOver)
        {
            checkGameOver = false;  //계속적으로 gameover를 검사하지 않기 위한 if 문
        }
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();  //text 초기화 예상되는 출력 count: 숫자
        if (count>=15)
        {
            WinText.text = "You Win!!!";
        }
     
    }
}
