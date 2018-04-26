using UnityEngine;
using System.Collections;

public class SearchArea : MonoBehaviour
{
    private EnemyCtrl enemyCtrl;

    private void Start()
    {
        enemyCtrl = transform.root.GetComponent<EnemyCtrl>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            enemyCtrl.SetAttackTarget(other.transform);
    }
}