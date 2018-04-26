using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public float Distance = 5.0f;
    public float HorizontalAngle = 0.0f;
    public float RotAngle = 180.0f;
    public float VerticalAngle = 10.0f;
    public Transform LookTarget;
    public Vector3 Offset = Vector3.zero;

    InputManager inputManager;
    private void Start()
    {
        inputManager = FindObjectOfType<InputManager>();
    }
    private void LateUpdate()
    {
        if (inputManager.Moved())
        {
            float anglePerPixel = RotAngle / (float)Screen.width;
            Vector2 delta = inputManager.GetDeltaPosition();

            HorizontalAngle += delta.x * anglePerPixel;
            HorizontalAngle = Mathf.Repeat(HorizontalAngle, 360.0f);
            VerticalAngle -= delta.y * anglePerPixel;
            VerticalAngle = Mathf.Clamp(VerticalAngle, -60.0f, 60.0f);
        }
        if(LookTarget != null)
        {
            Vector3 lookPosition = LookTarget.position + Offset;

            Vector3 relativePos = Quaternion.Euler(VerticalAngle, HorizontalAngle, 0) * new Vector3(0, 0, -Distance);

            transform.position = lookPosition + relativePos;
            transform.LookAt(lookPosition);

            RaycastHit hitInfo;

            if(Physics.Linecast(lookPosition,transform.position,out hitInfo, 1 << LayerMask.NameToLayer("Ground")))
            {
                transform.position = hitInfo.point;
            }
        }
    }


}
