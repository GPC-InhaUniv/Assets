using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour {


    // Use this for initialization
    public GameObject[] Cube = new GameObject[4];

	void Start () {
      max = 4;
    }
    
    int max;
    // Update is called once per frame
    void Update () {
 
            Click();
            RClick();
    
	}
    void RClick()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Cube[max-1].SetActive(false);
            max--;
        }
    }

    void Click()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Cube[max].SetActive(true);
            max++;
        }
    }
}
