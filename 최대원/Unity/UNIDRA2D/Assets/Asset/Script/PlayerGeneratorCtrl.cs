using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGeneratorCtrl : MonoBehaviour {

    MainSettingCtrl mainSettingCtrl;

    public int playerChar;
    public string playerName;

    public GameObject playerBlue;
    public GameObject playerPurple;

    public Vector3 playerPosition;
    public GameObject player;

    PlayerLifeCtrl playerLife;
    PlayerController playerController;
    PlayerState playerState;

    // Use this for initialization
    void Start ()
    {
        mainSettingCtrl = FindObjectOfType<MainSettingCtrl>();
        playerChar = mainSettingCtrl.PlayerChar;
        playerName = mainSettingCtrl.PlayerName;
        playerLife = FindObjectOfType<PlayerLifeCtrl>();
        playerController = FindObjectOfType<PlayerController>();

        switch (playerChar)
        {
            case 0:
                player = Instantiate(playerBlue);
                break;
            case 1:
                player = Instantiate(playerPurple);
                break;
            default:
                break;
        }

        playerPosition = player.transform.position;
        Destroy(mainSettingCtrl);
    }

    private void FixedUpdate()
    {
        if(player != null)
        playerPosition = player.transform.position;
    }

    public int GetPlayerLife()
    {
        if (player != null)
            return playerLife.PlayerLifeNum;
        else return -1;
    }
}
