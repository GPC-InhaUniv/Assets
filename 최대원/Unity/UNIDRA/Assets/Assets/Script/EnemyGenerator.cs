using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

    public GameObject enemyPrefab;
    GameObject[] existEnemys;
    public int maxEnemy = 3;
    public int RespawnRange = 10;

    IEnumerator Exec()
    {
        while (true)
        {
            Generate();
            yield return new WaitForSeconds(3.0f);
        }
    }


	// Use this for initialization
	void Start ()
    {
        existEnemys = new GameObject[maxEnemy];
        StartCoroutine(Exec());
	}
	
	void Generate()
    {
        for (int enemycount = 0; enemycount < existEnemys.Length; ++enemycount)
        {
            if(existEnemys[enemycount] == null)
            {
                Vector3 position = new Vector3(Random.Range(0, RespawnRange), 0, Random.Range(0, RespawnRange));
                existEnemys[enemycount] = Instantiate(enemyPrefab, transform.position + position, transform.rotation) as GameObject;
                return;
            }
        }
    }
}
