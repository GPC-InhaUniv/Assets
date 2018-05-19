using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BackGround") return;

        Instantiate(explosion, transform.position, transform.rotation);

        if(other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            GameController.GameOver();
        }
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
