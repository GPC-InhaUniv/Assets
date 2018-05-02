using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeCtrl : MonoBehaviour
{
    public int PlayerLifeNum;
    public Texture Heart;
    public float HeartScaleX = 0.25f;
    public float HeartScaleY = 0.25f;

    private void OnGUI()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        for (int i = 0; i < PlayerLifeNum; i++)
        {
            GUI.Label(new Rect(posX + (Heart.width * i), posY, Heart.width, Heart.height), new GUIContent(Heart));
        }
    }
}
