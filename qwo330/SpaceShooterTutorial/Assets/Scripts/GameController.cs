using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] hazard;
    public Vector3 SpawnValues;

    public int hazardCount;
    public float spawnWait = 0.5f;
    public float startWait = 1f;
    public float waveWait = 4f;

    int AsteroidNumber;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnWaves());
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while(true)
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
        }
    }

    public static void GameOver()
    {

    }
}
