using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRuleCtrl : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPrefab;
    public GameObject RhinoPrefab;
    public Transform startPoint;
    public FollowCamera followCamera;

    public float TimeRemaining = 5.0f * 60.0f;

    public bool gameOver = false;

    public bool gameClear = false;

    public float SceneChangeTime = 3.0f;

    public AudioClip clearSeClip;

    AudioSource clearSeAudio;

    NetworkView nView;

    private void Start()
    {
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;

        NetworkView myNetView = GetComponent<NetworkView>();
        nView = myNetView;

    }


    // Update is called once per frame
    void Update()
    {
        if(player ==null &&(Network.isServer|| Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5f, 0,0);
            player = Network.Instantiate(playerPrefab, startPoint.position + shiftVector, startPoint.rotation, 0) as GameObject;
            if (Network.isServer)
                RhinoPrefab = Network.Instantiate(RhinoPrefab, transform.position, transform.rotation, 0) as GameObject;

            followCamera.LookTarget = player.transform;
            //player.AddComponent<NetworkView>();
            NetworkView myNetView = player.GetComponent<NetworkView>();

            

            NetworkManager networkManager = FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
            myNetView.RPC("SetName", RPCMode.AllBuffered, networkManager.GetPlayerName());

        }

        if (gameOver || gameClear)
        {
            SceneChangeTime -= Time.deltaTime;
            if (SceneChangeTime <= 0.0f)
            {
                SceneManager.LoadScene("TitleScene");
            }
            return;
        }

        if (Network.isServer || Network.isClient)
        {
            TimeRemaining -= Time.deltaTime;
            if (TimeRemaining <= 0.0f)
            {
                GameOver();
            }
        }
    
    }

    public void GameOver()
    {
        if (!gameOver && Network.isServer)
            nView.RPC("GameOverOnNetwork", RPCMode.AllBuffered);
        Debug.Log("GameOver");
    }
    [RPC]
    void GameOverOnNetwork()
    {
        gameOver = true;
    }

    public void GameClear()
    {
        if (!gameClear && Network.isServer)
            nView.RPC("GameClearOnNetwork", RPCMode.AllBuffered);
    }
    [RPC]
    void GameClearOnNetwork()
    {
        gameClear = true;
    }
    [RPC]
    void SetRemainTime(float time)
    {
        TimeRemaining = time;
    }
    void OnPlayerConnected(NetworkPlayer player)
    {
        NetworkView myNetView = GetComponent<NetworkView>();
        nView = myNetView;
        nView.RPC("SetRemainTime", player, TimeRemaining);
    }
}
