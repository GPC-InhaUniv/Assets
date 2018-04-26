using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    private Vector2 slideStartPosition;
    private Vector2 prevPosition;
    private Vector2 delta = Vector2.zero;
    private bool moved = false;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            slideStartPosition = GetCursorPosition();

        if (Input.GetButton("Fire1"))
        {
            if (Vector2.Distance(slideStartPosition, GetCursorPosition()) >= (Screen.width * 0.1f)) moved = true;
        }

        if (!Input.GetButtonUp("Fire1") && !Input.GetButton("Fire1"))
            moved = false;

        if (moved)
            delta = GetCursorPosition() - prevPosition;
        else
            delta = Vector2.zero;

        prevPosition = GetCursorPosition();
    }

    // 클릭되었는가.
    public bool Clicked()
    {
        if (!moved && Input.GetButtonUp("Fire1"))
            return true;
        else
            return false;
    }

    // 슬라이드할 때 커서 이동량.
    public Vector2 GetDeltaPosition()
    {
        return delta;
    }

    // 슬라이드 중인가.
    public bool Moved()
    {
        return moved;
    }

    public Vector2 GetCursorPosition()
    {
        return Input.mousePosition;
    }
}