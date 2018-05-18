using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerexplosion;
    public int ScoreValue;
    private GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if(gameController == null)
        {
            Debug.Log("게임 컨트롤러를 찾을 수 없습니다.");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerexplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        gameController.AddSocre(ScoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

}
