using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {


    public GameObject hazard;
    public Vector3 spawnValue;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text scoreText;
    
    public Text restartText;
    public Text gameOverText;
    public Text gameClearText;

    private int score;
    private bool gameOver;
    private bool restart;
    private bool gameClear;


    private void Start()
    {
        gameOver = false;
        gameClear = false;

        restart = false;
        if(restartText != null)
        {
            restartText.text = "";
        }
        if(gameOverText != null)
        {
            gameOverText.text = "";
        }
        if (gameClearText != null)
        {
            gameClearText.text = "";
        }
       
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }
    public void GameOver()
    {
        gameOverText.text = "GameOver";
        gameOver = true;
    }
    public void GameClear()
    {
        gameClearText.text = "GameClear!";
        gameClear = true;
    }
    private void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
              
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), spawnValue.y, spawnValue.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'R' for restart";
                restart = true;
                break;
            }
        }     
    }
    public void AddSocre (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        if(scoreText != null)
        {
            scoreText.text = "Score : " + score;
        }
        if (score >= 100)
        {
            GameClear();
        }

    }

}
