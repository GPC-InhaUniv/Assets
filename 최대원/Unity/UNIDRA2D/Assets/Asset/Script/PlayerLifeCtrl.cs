using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeCtrl : MonoBehaviour
{
    public int PlayerLifeNum;
    public Texture Heart;

    private void OnGUI()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        for (int i = 0; i < PlayerLifeNum; i++)
        {
            GUI.Label(new Rect(posX + (Heart.width * i) + 25f, posY, 64f, 64f), new GUIContent(Heart));
        }
    }
}
