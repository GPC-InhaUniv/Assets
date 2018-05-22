using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10.0f;
    public float tilt = 15.0f;
    public Bounadry boundary;

    Rigidbody rig;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate = 0.25f;
    float nextFire = 0.0f;
    new AudioSource audio;

    private void Start()
    {
        rig = this.GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            audio.Play();
        }
    }

    Vector3 movement;
    Vector3 privPosition, nowPosition;
    public float gap = 40f;
    private void FixedUpdate()
    {
        //if(Input.anyKeyDown)
        {
            Debug.Log("KeyMove");
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rig.velocity = movement * speed;

            rig.position = new Vector3(
                Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax),
                0.0f,
                Mathf.Clamp(rig.position.z, boundary.zMin, boundary.zMax)
                );
            rig.rotation = Quaternion.Euler(0.0f, 0.0f, rig.velocity.x * -tilt);
        }
        //else
        //{
        //    Debug.Log("Drag");
        //    movement = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    transform.position = new Vector3(movement.x, 0.0f, movement.z);
        //    rig.rotation = Quaternion.Euler(0.0f, 0.0f, rig.velocity.x * -tilt);
        //}
    }
}
[System.Serializable]
public class Bounadry
{
    public float xMin, xMax, zMin, zMax;
}