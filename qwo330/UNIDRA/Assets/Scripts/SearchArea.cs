using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchArea : MonoBehaviour {

    EnemyCtrl enemyCtrl;

    // Use this for initialization
    void Start () {
        enemyCtrl = transform.root.GetComponent<EnemyCtrl>();
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            enemyCtrl.SetAttackTarget(other.transform);
    }
}
