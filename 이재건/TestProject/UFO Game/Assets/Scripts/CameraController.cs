using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Vector3 offset;  //지속적인 카메라 위치를 저장할 offset vector
    public GameObject Player;  //위치를 받아올 gameobject (즉 주인공 플레이어)

    private void Start()
    {
        offset = transform.position - Player.transform.position;  //초기 카메라위치와 player위치의 차이로 초기값을 잡아줌
    }

    private void LateUpdate()  //모든 업데이트가 종료되고 나서야 업데이트를 실행하는 함수
    {
        transform.position = Player.transform.position + offset; //카메라의 위치는 초기 offset + 현재 플레이어의 위치!
    }


}
