using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject enemyPrefab;
    public GameObject enemyTigerPrefab;
    GameObject[] existEnemys;
    GameObject[] existTigerEnemys;
    public int maxEnemy = 3;
    public int maxEnemyTiger = 3;
    public int RespawnRange = 10;

    IEnumerator Exec()
    {
        while (true)
        {
            if (Network.isServer)
            {
                Generate();
            }
            yield return new WaitForSeconds(3.0f);
        }
    }

	// Use this for initialization
	void Start ()
    {
        existEnemys = new GameObject[maxEnemy];
        existTigerEnemys = new GameObject[maxEnemyTiger];
        StartCoroutine(Exec());
    }
	
	void Generate()
    {
        for (int enemycount = 0; enemycount < existEnemys.Length; ++enemycount)
        {
            if(existEnemys[enemycount] == null)
            {
                Vector3 position = new Vector3(Random.Range(0, RespawnRange), 0, Random.Range(0, RespawnRange));
                existEnemys[enemycount] = Network.Instantiate(enemyPrefab, transform.position + position, transform.rotation, 0) as GameObject;
                return;
            }
        }

        for (int enemycount = 0; enemycount < existTigerEnemys.Length; ++enemycount)
        {
            if (existTigerEnemys[enemycount] == null)
            {
                Vector3 position = new Vector3(Random.Range(0, RespawnRange), 0, Random.Range(0, RespawnRange));
                existTigerEnemys[enemycount] = Network.Instantiate(enemyTigerPrefab, transform.position + position, transform.rotation, 0) as GameObject;
                return;
            }
        }
    }
}
