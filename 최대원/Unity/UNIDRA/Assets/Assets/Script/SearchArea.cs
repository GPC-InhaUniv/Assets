using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchArea : MonoBehaviour
{

    CharacterStatus characterStatus;
    EnemyCtrl enemyCtrl;
	// Use this for initialization
	void Start ()
    {
        enemyCtrl = transform.root.GetComponent<EnemyCtrl>();
    }

    void OnTriggerStay(Collider other)
    {
        characterStatus = other.GetComponent<CharacterStatus>();
        if (other.tag == "Player" && characterStatus.died == false)
        {
            enemyCtrl.SetAttackTarget(other.transform);
        }
    }
}
