using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject Hazard;
    public Vector3 SpawnValues;

    public int HazardCount;
    public float SpawnWait;
    public float StartWait;
    public float waveWait;

    public Text ScoreText;
    public Text RestartText;
    public Text GameOverText;

    private bool gameOver;
    private bool restart;
    private int Score;

  

    void Start() {
        gameOver = false;
        RestartText.text = "";
        GameOverText .text=  "";
        Score = 0;
        UpdateScore();
        StartCoroutine(spawnwaves());
    }

    private void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator spawnwaves()
    {
        yield return new WaitForSeconds(StartWait);
        while (true) {
            for (int i = 0; i < HazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3((Random.Range(-SpawnValues.x, SpawnValues.x)), SpawnValues.y, SpawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(SpawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                RestartText.text = "Press 'R' for Restart";
                restart = true;
                break;

            }
        }

    }

    public void AddScore( int NewScore)
    {
        Score += NewScore;
        UpdateScore();
    }

    void UpdateScore()      //score를 출력해준다.
    {
        ScoreText.text = "Score : " + Score;
             
    }
    public void GameOver()
    {
        GameOverText.text = "Game Over";
        gameOver = true;
    }
}
