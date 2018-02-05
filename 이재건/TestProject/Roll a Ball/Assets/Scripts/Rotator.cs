using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);//프레임 업데이트 마다 vecotr3값과 시간값을 곱하여 
                                                                    //회전시켜준다.
	}
}
