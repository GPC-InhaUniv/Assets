 
using UnityEngine;

public class FanRotation : MonoBehaviour {

    public float Mult;
    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime* Mult, Space.Self);
    }
}
