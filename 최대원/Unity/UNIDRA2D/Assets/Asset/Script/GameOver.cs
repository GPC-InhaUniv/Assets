using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Texture GameOverTexture;
    float animationY;
    PlayerGeneratorCtrl playerGenerator;


    private void Start()
    {
        animationY = -(int)Screen.height / 2;
        playerGenerator = FindObjectOfType<PlayerGeneratorCtrl>();


    }

    private void Update()
    {
        if (Input.anyKeyDown && (playerGenerator.GetPlayerLife() == -1))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0 + animationY, Screen.width, Screen.height), GameOverTexture);
        if(animationY < 0)
        {
            animationY += 9;
        }
    }
}
