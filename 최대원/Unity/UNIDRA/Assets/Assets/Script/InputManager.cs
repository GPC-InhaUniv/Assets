using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public float turnSpeed; //회전 속도
    Vector3 cameraDirection;
    Vector3 playerDirection;

    void Update()
    {
        cameraDirection = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * turnSpeed;
        playerDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
	// 클릭되었는가.
	public bool Clicked()
	{
		if (Input.GetButtonUp("Fire1"))
			return true;
		else
			return false;
	}	
	
    public Vector3 GetCameraDiretion()
    {
        return cameraDirection;
    }

    public Vector3 GetPlayerDiretion()
    {
        return playerDirection;
    }

    public Vector2 GetCursorPosition()
	{
		return Input.mousePosition;
	}
}
