using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float Xmin, Xmax, Zmin, Zmax;
}


public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float tilt;
    public Boundary boundary;

    public GameObject Shot;
    public Transform ShotSpawn ;

    private float nextFire;
    public float fireRate;  //초당 4번 발사 : 0.25

  
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
            GetComponent<AudioSource>().Play();
            
        }
    }









    private void FixedUpdate()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MoveHorizontal,0.0f,MoveVertical);

        rigidbody.velocity = movement*Speed;

        rigidbody.position = new Vector3
        (
            Mathf.Clamp(rigidbody.position.x, boundary.Xmin, boundary.Xmax),
            0.0f,
            Mathf.Clamp(rigidbody.position.z,boundary.Zmin,boundary.Zmax)
        );

        rigidbody.rotation = Quaternion.Euler(0.0f,0.0f,rigidbody.velocity.x*-tilt);



    }


    

}
