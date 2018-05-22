using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float zMin, zMax, xMin, xMax;
}

public class PlayerController : MonoBehaviour {
    [Range(0,10)]
    public float speed;
    [Range(0, 5)]
    public float tilt;

    public Boundary boundary;

    public GameObject shot;
    public Transform shotSpawn;

    public float fireRate;

    private float nextFire;

    public AudioClip attackSeClip;
    AudioSource attackSeAudio;

    [Range(-1, 1)]
    public float AudioVolume;

    void Start()
    {
        attackSeAudio = gameObject.AddComponent<AudioSource>();
        attackSeAudio.loop = false;
        attackSeAudio.clip = attackSeClip;
        attackSeAudio.volume = AudioVolume;
    }

    void FixedUpdate()
    {
        Rigidbody PlayerRigidbody = GetComponent<Rigidbody>();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        PlayerRigidbody.velocity = movement * speed;

        PlayerRigidbody.position = new Vector3
            (
            Mathf.Clamp (PlayerRigidbody.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(PlayerRigidbody.position.z, boundary.zMin, boundary.zMax)
            );
        PlayerRigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, PlayerRigidbody.velocity.x * -tilt);
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            attackSeAudio.Play();
        }
        
    }
}

