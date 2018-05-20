using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin=-6, xMax=6, zMin=-4, zMax=8;
}
public class PlayerController : MonoBehaviour {
    public Rigidbody rb;
    public float speed=10;
    public float tilit;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate = 0.5f;
    public float nextFire = 0.0f;
    public AudioSource audio;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audio.Play();
        }
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement=new Vector3(moveHorizontal,0.0f, moveVertical);
        rb.velocity = movement * speed ;
        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x,boundary.xMin,boundary.xMax),
            3.46f,
            Mathf.Clamp(rb.position.z,boundary.zMin,boundary.zMax)
        );

        rb.rotation = Quaternion.Euler(0.0f,0.0f,rb.velocity.x*-tilit);
    }


}
