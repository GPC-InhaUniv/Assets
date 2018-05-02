using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Texture GameOverTexture;
    float animationY = -200;

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0 + animationY, Screen.width, Screen.height), GameOverTexture);
        if(animationY < 0)
        {
            animationY += 3;
        }
    }
}
