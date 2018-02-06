using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;  //player 참조를 위한 선언 후에 참조값을 public이기때문에 스크립트 종료후 넣어주어야 한다
    //public  PlayerController mm;
    private Vector3 offset;       //offset value : 현재의 카메라 transform 위치에서 플레이어의 transform
                                    //위치의 차로 구함

    

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position; //카메라 위치에서 player위치의 차이 =offset
       // mm = GameObject.Find("Player").GetComponent<PlayerController>();
      //  mm.speed = 50;
      
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {     //LateUpdate : update가 모두 처리되고 나서 update 되는 함수

        transform.position = player.transform.position + offset; //모든 frame에서 transform 위치는 플레이어의
                                                                 //transform 위치와 offset 위치를 더하여 매 프레임마다
                                                                 //카메라가 플레이어 오브젝트와 연계된 새 위치로 이동
	}
}
