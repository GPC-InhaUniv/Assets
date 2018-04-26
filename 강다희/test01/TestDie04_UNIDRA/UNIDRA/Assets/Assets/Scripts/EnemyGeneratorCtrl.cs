using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorCtrl : MonoBehaviour
{
    public GameObject enemyPrefab; //생겨날 적

    private GameObject[] existEnemys;//적을 저장

    public int maxEnemy = 2; //액티브 최대 수

    private void Start()
    {
        existEnemys = new GameObject[maxEnemy];
        StartCoroutine(Exec());
    }

    private IEnumerator Exec()
    {
        while (true)
        {
            if (Network.isServer)
                Generate();
            yield return new WaitForSeconds(3.0f);
        }
    }

    private void Generate()
    {
        for (int enemyCount = 0; enemyCount < existEnemys.Length; ++enemyCount)
        {
            if (existEnemys[enemyCount] == null)
            {
                // 적 생성.
                existEnemys[enemyCount] = Network.Instantiate(enemyPrefab, transform.position, transform.rotation, 0) as GameObject;
                return;
            }
        }
    }
}