using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRuleCtrl : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPrefab;
    public Transform startPoint;
    public FollowCamera followCamera;

    public float timeRemaining = 5.0f * 60.0f;
    public bool gameOver = false;
    public bool gameClear = false;
    public float sceneChangeTime = 3.0f;

    public AudioClip clearSeClip;
    private AudioSource clearSeAudio;
    public NetworkView networkView;

    private void Start()
    {
        networkView = GetComponent<NetworkView>();

        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
    }

    private void Update()
    {
        // 플레이어 생성.
        if (player == null && (Network.isServer || Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5f, 0, 0);
            player = Network.Instantiate(playerPrefab, startPoint.position + shiftVector, startPoint.rotation, 0) as GameObject;
            followCamera.lookTarget = player.transform;
            // 이름 송신.
            NetworkManager networkManager = FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
            player.GetComponent<NetworkView>().RPC("SetName", RPCMode.AllBuffered, networkManager.GetPlayerName());
        }

        // 게임 종료 조건 성립 후 씬 전환.
        if (gameOver || gameClear)
        {
            sceneChangeTime -= Time.deltaTime;
            if (sceneChangeTime <= 0.0f)
            {
                Application.LoadLevel("TitleScene");
            }
            return;
        }

        // 게임이 시작되면 타이머를 움직인다.
        if (Network.isServer || Network.isClient)
        {
            timeRemaining -= Time.deltaTime;
            // 남은 시간이 없으면 게임 오버.
            if (timeRemaining <= 0.0f)
            {
                GameOver();
            }
        }
    }

    public void GameOver()
    {
        if (!gameOver && Network.isServer)
            networkView.RPC("GameOverOnNetwork", RPCMode.AllBuffered);
    }

    [RPC]
    private void GameOverOnNetwork()
    {
        gameOver = true;
    }

    public void GameClear()
    {
        if (!gameClear && Network.isServer)
            networkView.RPC("GameClearOnNetwork", RPCMode.AllBuffered);
    }

    [RPC]
    private void GameClearOnNetwork()
    {
        gameClear = true;
    }

    [RPC]
    private void SetRemainTime(float time)
    {
        timeRemaining = time;
    }

    private void OnPlayerConnected(NetworkPlayer player)
    {
        networkView.RPC("SetRemainTime", player, timeRemaining);
    }
}