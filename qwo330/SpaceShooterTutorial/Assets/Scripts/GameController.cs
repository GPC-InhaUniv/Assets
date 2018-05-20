using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject[] hazard;
    public Vector3 SpawnValues;

    public int hazardCount;
    public float spawnWait = 0.5f;
    public float startWait = 1f;
    public float waveWait = 4f;

    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;

    int AsteroidNumber;
    int score;
    bool gameOver;
    bool reStart;

    // Use this for initialization
    void Start () {
        score = 0;
        gameOver = false;
        reStart = false;
        restartText.text = "";
        gameOverText.text = "";

        UpdateScore();
        StartCoroutine(SpawnWaves());
	}

   void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game");
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), SpawnValues.y, SpawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;

                AsteroidNumber = Random.Range(0, 3);
                switch (AsteroidNumber)
                {
                    case 0:
                        Instantiate(hazard[0], spawnPosition, spawnRotation); break;
                    case 1:
                        Instantiate(hazard[1], spawnPosition, spawnRotation); break;
                    case 2:
                        Instantiate(hazard[2], spawnPosition, spawnRotation); break;
                    default: break;
                }
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            
            if(gameOver)
            {
                restartText.text = "Press 'R' for ReStart";
                reStart = true;
                break;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
