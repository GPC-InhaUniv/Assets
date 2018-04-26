using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRuleCtrl : MonoBehaviour {

    public GameObject player;
    public GameObject playerPrefab;
    public Transform startPoint;
    public FollowCamera followCamera;

    public float sceneChangeTime = 3.0f;
    public float timeRemaining = 5.0f * 60.0f;
    public bool gameOver = false;
    public bool gameClear = false;

    public AudioClip clearSeClip;
    AudioSource clearSeAudio;

    new NetworkView networkView;

    private void Start()
    {
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
        networkView = GetComponent<NetworkView>();
    }

    // Update is called once per frame
    void Update () {
        // 플레이어 생성
        if (player == null && (Network.isServer || Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5f, 0, 0);
            player = Network.Instantiate(playerPrefab, startPoint.position + shiftVector, startPoint.rotation, 0) as GameObject;
            followCamera.SetTarget(player.transform);
            // 이름 송신
            NetworkManager networkManager = FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
            player.GetComponent<NetworkView>().RPC("SetName", RPCMode.AllBuffered, networkManager.GetPlayerName());
        }

        if (gameOver || gameClear)
        {
            sceneChangeTime -= Time.deltaTime;
            if (sceneChangeTime <= 0.0f)
            {
                SceneManager.LoadScene("TitleScene");
            }
            return;
        }

        if(Network.isServer || Network.isClient)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0.0f)
                GameOver();
        }
    }

    public void GameOver()
    {
        if (!gameOver && Network.isServer)
            networkView.RPC("GameOverOnNetwork", RPCMode.AllBuffered);
        //networkView.RPC("GameOverOnNetwork", RPCMode.AllBuffered);
    }

    [RPC]
    void GameOverOnNetwork()
    {
        gameOver = true;
    }

    public void GameClear()
    {
        if (!gameClear && Network.isServer)
            networkView.RPC("GameClearOnNetwork", RPCMode.AllBuffered);
    }

    [RPC]
    void GameClearOnNetwork()
    {
        gameClear = true;
        clearSeAudio.Play();
    }

    //private void OnNetworkInstantiate(NetworkMessageInfo info)
    //{
    //    networkView = GetComponent<NetworkView>();
    //}

    [RPC]
    void SetRemainTime(float time)
    {
        timeRemaining = time;
    }

    private void OnPlayerConnected(NetworkPlayer player)
    {
        GetComponent<NetworkView>().RPC("SetRemainTime", player, timeRemaining);
    }
}
