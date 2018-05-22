using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValue;
    public float Interval;
    public int TryCount;
    public float StartWaveTime;
    public float NextWaveTime;
    public GameObject Player;
    public TextMesh ScoreText;
    private int Score;

    private void Start()
    {
        StartCoroutine(SpawnWave());
        Score = 0;
        UpdateScore();
    }

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(StartWaveTime);
        while (Player != null)
        {
            for (int i = 0; i < TryCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), 0, spawnValue.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(Interval);
            }
            TryCount++;
            yield return new WaitForSeconds(NextWaveTime);
        }
    }

    public void AddScore(int ScoreValue)
    {
        Score += ScoreValue;
        UpdateScore();
    }

    private void UpdateScore()
    {
        ScoreText.text = "Score : " + Score;
    }
}
