using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

    public GameObject Hazard;
    public Vector3 SpawnValue;
    public int HazardCount;
    public float SpawnWait;
    public float StartWait;
    public float WaveWait;

    public Text ScoreText;
    public Text RestartText;
    public Text GameOverText;
    
    private int Score;
    private bool gameover;
    private bool restart;

    private void Start()
    {
        gameover = false;
        restart = false;
        RestartText.text = "";
        GameOverText.text = "";
        Score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());

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
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(StartWait);
        while (true)
        {
            for (int i = 0; i < HazardCount; i++)
            {
                Vector3 SpawPosition = new Vector3(Random.Range(-SpawnValue.x, SpawnValue.x), SpawnValue.y, SpawnValue.z);
                Quaternion SpawnRotatation = Quaternion.identity;
                Instantiate(Hazard, SpawPosition, SpawnRotatation);
                yield return new WaitForSeconds(SpawnWait);
            }
            yield return new WaitForSeconds(WaveWait);

            if (gameover)
            {
                RestartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }

        }
    }
    public void AddScore(int newScoreValue)
    {
        Score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Score : " + Score;
    }

    public void GameOver()
    {
        GameOverText.text = "Game Over!";
        gameover = true;
    }
}
