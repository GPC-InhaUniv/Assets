using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilityController : MonoBehaviour {
    public PlayerStatus playerstatus;

    private void Start()
    {
        playerstatus = FindObjectOfType<PlayerStatus>();
    }
    void Update()
    {
        if (playerstatus.HP <= 0)
            Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ItemCtrl.currentItemCount--;
            ItemCtrl.IsGetItem = true;
            Destroy(gameObject);
        }
    }

}
