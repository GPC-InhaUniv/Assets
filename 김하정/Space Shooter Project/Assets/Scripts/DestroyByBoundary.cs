using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

    //트리거 볼륨을 벗어나는 모든 오브젝트를 파괴!
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }

    
}
