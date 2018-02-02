using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;   //속도를 조절하기 위한 변수값으로 손쉽게 조절 할 수 있도록 public으로 사용

    private Rigidbody rb;  //물리제어 class 로 객체 rb를 생성

    private int count;  //점수를 위한 변수
    public Text countText; //점수를 출력하기 위한 text class
    public Text WinText;  //종료 ui를 위한 text class

    void Start()
    {
        rb = GetComponent<Rigidbody>();  //rigidbody에 대한 정보를 rb에 저장시켜 준다 . 프로그램이 시작되면.
        count = 0;  //점수는 0점으로 초기화
        SetCountText();
        WinText.text = " ";
    }
    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  //float value for move player  right or left
        float moveVertical = Input.GetAxis("Vertical");      //float value for move player  up   or down

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);   //x,y,z vetor  x: right or left
                                                                              //y : not use , z: up or down

        rb.AddForce(movement*speed);   //물리력은 키보드로 입력받은 방향 * 속도 변수값                       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))  //만일 충돌한 object가 pick up 이라는 이름을 갖는다면
        {
            other.gameObject.SetActive(false);  //충돌한 object를 비활성화 시킨다.
            count++;                            //충돌시 점수 획득
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();  //text 초기화 예상되는 출력 count: 숫자
        if(count>=15)
        {
            WinText.text = "You Win!!!";
        }
         
    }
}
