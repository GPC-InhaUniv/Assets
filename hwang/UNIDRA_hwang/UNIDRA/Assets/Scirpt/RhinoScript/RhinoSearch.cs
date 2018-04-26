using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoSearch : MonoBehaviour {


    RhinoCtrl rhinoCtrl;

    // Use this for initialization
    void Start()
    {
        rhinoCtrl = transform.root.GetComponent<RhinoCtrl>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            rhinoCtrl.SetAttackTarget(other.transform);
    }

}
