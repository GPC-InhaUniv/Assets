using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorCtrl : MonoBehaviour {

    public GameObject EnemyPrefab;

    GameObject[] existEnemys;

    public int maxEnemy = 2;

	// Use this for initialization
	void Start () {

        existEnemys = new GameObject[maxEnemy];

        StartCoroutine(Exec());
		
	}
	

    IEnumerator Exec()
    {
        while (true)
        {
            if (Network.isServer)
                Generate();
            yield return new WaitForSeconds(3.0f);
        }
    }

    void Generate()
    {
        
        for (int enemyCount = 0; enemyCount < existEnemys.Length; ++enemyCount)
        {
            if (existEnemys[enemyCount] == null)
            {
                existEnemys[enemyCount] = Network.Instantiate(EnemyPrefab, transform.position, transform.rotation,0) as GameObject;
                return;
            }
        }
    }
}
