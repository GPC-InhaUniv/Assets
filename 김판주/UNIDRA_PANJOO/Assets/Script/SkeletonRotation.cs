using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonRotation : MonoBehaviour {

    // Use this for initialization
    Transform srotation;
    float temp;
    Quaternion quaternionSK;

    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
       

        if (transform.rotation.eulerAngles.y > 80)
        {
            Vector3 temp = transform.rotation.eulerAngles;
            temp.y-=5;
            transform.rotation = Quaternion.EulerAngles(temp);

        }
	}
}
