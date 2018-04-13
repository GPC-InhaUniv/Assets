using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public float distance = 5.0f;
    public float horizontalAngle = 0.0f;
    public float rotAngle = 180.0f; // 화면 가로폭만큼 커서를 이동시켰을 때 회전하는 각도
    public float verticalAngle = 10.0f;
    public Transform lookTarget;
    public Vector3 offset = new Vector3(0, 1.5f, 0);

    InputManager inputManager;

	// Use this for initialization
	void Start () {
        inputManager = FindObjectOfType<InputManager>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// 드래그 입력으로 카메라 회전각을 갱신한다.
        if(inputManager.Moved())
        {
            float anglePerPixel = rotAngle / (float)Screen.width;
            Vector2 delta = inputManager.GetDeltaPosition();

            horizontalAngle += delta.x * anglePerPixel;
            horizontalAngle = Mathf.Repeat(horizontalAngle, 360.0f);

            verticalAngle -= delta.y * anglePerPixel;
            verticalAngle = Mathf.Clamp(verticalAngle, -60.0f, 60.0f);
        }
        // 카메라의 위치와 회전각을 갱신한다.
        if(lookTarget != null)
        {
            Vector3 lookPosition = lookTarget.position + offset;
            // 주시 대상에서 상대 위치를 구한다.
            Vector3 relativePos = Quaternion.Euler(verticalAngle, horizontalAngle, 0) * new Vector3(0, 0, -distance);

            transform.position = lookPosition + relativePos;
            transform.LookAt(lookPosition);
            
            // 장애물을 피한다.
            RaycastHit hitInfo;
            if (Physics.Linecast(lookPosition, transform.position, out hitInfo, 1 << LayerMask.NameToLayer("Ground")))
                transform.position = hitInfo.point;
        }
	}
}
