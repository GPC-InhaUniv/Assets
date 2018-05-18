using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

    public Rigidbody Rb;
    public float Speed;
    public float tilt;
    public Boundary boundary;

    public GameObject Shot;
    public Transform ShotSpawn;
    public float FireRate;
    private float nextFire;
    public AudioSource Ac;
 
    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Ac = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;
            Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
            Ac.Play();
            //Debug.Log();
            
        }
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");  
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Rb.velocity = movement * Speed;
        Rb.position = new Vector3(
            Mathf.Clamp(Rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(Rb.position.z, boundary.zMin, boundary.zMax)
            );
        Rb.rotation = Quaternion.Euler(0.0f, 0.0f, Rb.velocity.x*-tilt);
    }
}
