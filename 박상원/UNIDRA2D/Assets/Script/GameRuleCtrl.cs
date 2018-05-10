using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRuleCtrl : MonoBehaviour
{
    // 남은 시간
    public float timeRemaining = 30.0f;

    // 게임 오버
    public bool gameOver = false;

    // 게임 클리어
    public bool gameClear = false;
	
	void Update ()
    {
        if (gameClear==false && gameOver==false)
        {
            // 남은 시간이 0 이 되면 게임 클리어
            Timerate();
        }
        else if(gameClear==true || gameOver==true)
        {
            return;
        }

        if (timeRemaining <= 0.0f)
        {
            GameClear();
        }
    }

    void Timerate()
    {
        timeRemaining -= Time.deltaTime;
    }

    public void GameClear()
    {
        gameClear = true;
    }

    public void GameOver()
    {
        gameOver = true;
    }
}
