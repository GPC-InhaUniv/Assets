using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {
    public GameObject player; //플레이어에 대한 퍼블릭 게임 오브젝트 참조

    private Vector3 offset; //오프셋 값을 갖게될 프라이빗 벡터3 //오프셋은 여기 스크립트에서 해당값을 설정할 수 있으므로 private를 사용한다.
                            // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position; //현재 카메라의 tranform 위치 - 플레이어의 transform위치 
	}
	
	// Update is called once per frame
	void LateUpdate () {    //추적 카메라, 절차 애니메이션 그리고 마지막으로 알려진 상태의 수집 등을 위해서는 LateUpdate를 사용하는 것이 좋다.
        transform.position = player.transform.position + offset;    //설정하는 모든 프레임에서 트랜스폼 위치는 플레이어의 트랜스폼 위치와 오프셋을 더한 값과 같다고 설정
	}
}
