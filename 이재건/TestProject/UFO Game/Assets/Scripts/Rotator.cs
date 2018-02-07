using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime); //z축 방향으로 45만큼 시간의 흐름 만큼 곱해주어 회전시켜줌
    }
}
