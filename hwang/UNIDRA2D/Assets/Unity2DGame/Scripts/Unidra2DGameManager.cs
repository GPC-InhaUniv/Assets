using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    Start ,
    GameOver ,
}

public class Unidra2DGameManager : MonoBehaviour {

    public Text ScoreText;
    public Text PlayerLifeText;
    public Text GameOverText;
    public GameObject Enemy;
    public GameObject Player;

    public GameState NowGamestate;
    int score = 0;
    int playerLife = 3;


    private static Unidra2DGameManager managerinstance = null;

    public static Unidra2DGameManager Managerinstance
    {
        get
        {
            if(managerinstance == null)
            {
                managerinstance = FindObjectOfType(typeof(Unidra2DGameManager)) as Unidra2DGameManager;

                if (managerinstance == null)
                {
                    Debug.LogError("There's no active managerclass object");
                }
            }
            return managerinstance;
            
        }
    }

    // Use this for initialization
    void Start()
    {
        NowGamestate = GameState.Start;

    }

    // Update is called once per frame
    void Update () {

        ScoreText.text = score.ToString();
        PlayerLifeText.text = "X" + playerLife.ToString();
	}

    public void AddScore()
    {
        score++;
    }
    public void GameOver()
    {
        NowGamestate = GameState.GameOver;
        GameOverText.gameObject.SetActive(true);
    }
    public void Damaged()
    {
        if (playerLife > 0)
            playerLife--;
        if (playerLife <= 0)
        {
            playerLife = 0;
            GameOver();
        }

    }
    public void ClickRestart()
    {
        score = 0;
        playerLife = 3;
        Enemy.transform.position = new Vector3(0.5f,1.5f,1f);
        Player.transform.position = new Vector3(-1.5f, -2.0f, 0f);
        NowGamestate = GameState.Start;
        GameOverText.gameObject.SetActive(false);
        Debug.Log(score);
    }
}
