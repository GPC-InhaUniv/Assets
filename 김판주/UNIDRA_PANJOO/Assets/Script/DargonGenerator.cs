using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DargonGenerator : MonoBehaviour
{

    // 생겨날 적 프리팹.
    public GameObject enemyPrefab;

    // 적을 저장한다. 
    GameObject existEnemys;

    void Start()
    {
        
    }

    
    private void Update()
    {
        if (Network.isServer)
            Generate();
        
    }


    void Generate()
    {
        // 적 생성.

        if (existEnemys == null)
        {
            // 적 생성.
            existEnemys = new GameObject();
            existEnemys = Network.Instantiate(enemyPrefab, transform.position, transform.rotation, 0) as GameObject;
            return;
        }



    }
}
