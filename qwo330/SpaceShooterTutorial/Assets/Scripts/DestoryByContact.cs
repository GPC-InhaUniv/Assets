using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    GameController gameController;
    public int scoreValue = 10;

    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        if (gameController == null) Debug.Log("GameController를 찾을 수 없습니다.");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BackGround") return;

        Instantiate(explosion, transform.position, transform.rotation);

        if(other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
