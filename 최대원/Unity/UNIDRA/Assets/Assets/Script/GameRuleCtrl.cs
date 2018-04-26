using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRuleCtrl : MonoBehaviour {

    public float timeRemaining = 5.0f * 60.0f;
    public bool gameOver = false;
    public bool gameClear = false;
    public float sceneChangeTime = 3f;

    public AudioClip clearSeClip;
    AudioSource clearSeAudio;

    public GameObject player;
    public GameObject playerPrefeb;
    public Transform startPoint;
    public FollowCamera followCamera;


    private void Start()
    {
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
    }
    // Update is called once per frame
    void Update ()
    {
        if(player == null && (Network.isServer || Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5f, 0, 0);
            player = Network.Instantiate(playerPrefeb, startPoint.position + shiftVector, startPoint.rotation, 0) as GameObject;
            followCamera.lookTarget = player.transform;
            
            NetworkManager networkManager = FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
            player.GetComponent<NetworkView>().RPC("SetName", RPCMode.AllBuffered, networkManager.GetPlayerName());
        }

        if (gameOver || gameClear)
        {
            sceneChangeTime -= Time.deltaTime;
            if (sceneChangeTime <= 0f)
            {
                SceneManager.LoadScene(0);
            }
            else return;
        }

        if (Network.isServer || Network.isClient)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0.0f)
            {
                GameOver();
            }
        }
	}

    public void GameOver()
    {
        if(!gameOver && Network.isServer)
        {
            GetComponent<NetworkView>().RPC("GameOverOnNetwork", RPCMode.AllBuffered);
        }
    }

    [RPC]
    void GameOverOnNetwork()
    {
        gameOver = true;
    }

    [RPC]
    void SetRemainTime(float time)
    {
        timeRemaining = time;
    }

    private void OnPlayerConnected(NetworkPlayer player)
    {
        GetComponent<NetworkView>().RPC("SetRemainTime", player, timeRemaining); 
    }

    public void GameClear()
    {
        if(gameClear && Network.isServer)
        {
            GetComponent<NetworkView>().RPC("GameClearOnNetwork", RPCMode.AllBuffered);
        }
        clearSeAudio.Play();
    }
    
    [RPC]
    void GameClearOnNetwork()
    {
        gameClear = true;
    }
}
