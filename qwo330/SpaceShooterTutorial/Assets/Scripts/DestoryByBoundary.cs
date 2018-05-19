using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByBoundary : MonoBehaviour {
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") return;
        Destroy(other.gameObject);
    }
}
