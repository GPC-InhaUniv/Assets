using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCtrl : MonoBehaviour
{
    public GameObject nextPrefeb;

    private void Update()
    {
        if (Input.anyKey)
        {
            Instantiate(nextPrefeb,new Vector2(0,0),Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
