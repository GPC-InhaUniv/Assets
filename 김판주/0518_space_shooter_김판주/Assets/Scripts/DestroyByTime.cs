using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {
    public float LifeTiem;

    private void Start()
    {
        Destroy(gameObject, LifeTiem);
    }
}
