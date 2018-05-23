using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text ScoreText;
    public Text GameOverText;
    public Text ReStartText;
    int ScoreTotal;
    bool reStart;
    bool gameOver;

    void Start ()
    {
        ScoreTotal = 0;
        UpdateScore();
        StartCoroutine (SpawnWaves ());
        GameOverText.text = "";
        ReStartText.text = "";

        reStart = false;
        gameOver = false;
    }

    void Update()
    {
        if(reStart)
        {
            if (Input.GetKeyDown(KeyCode.R))
                Application.LoadLevel(Application.loadedLevel);
        }
    }

    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds (startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            if(gameOver)
            {
                ReStart();
                break;
            }

            yield return new WaitForSeconds (waveWait);
        }
    }

    public void AddScore(int ScoreNumber)
    {
        ScoreTotal += ScoreNumber;
        UpdateScore();
    }

    void UpdateScore()
    {
       
        ScoreText.text = "Score : " + ScoreTotal;
    }

    void ReStart()
    {
        ReStartText.text = "Press 'R' for ReStart";
        reStart = true;

    }

    public void GameOver()
    {
        GameOverText.text = "Game Over!";
        gameOver = true;
    }

    
}