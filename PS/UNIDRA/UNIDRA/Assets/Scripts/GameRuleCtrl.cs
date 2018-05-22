﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRuleCtrl : MonoBehaviour
{
    // 자신의 컴퓨터에 있는 플레이어 게임 오브젝트
    public GameObject player;
    // 실체화되는 플레이어의 프리팹
    public GameObject playerPrefab;
    // 시작 위치
    public Transform startPoint;
    // FollowCamera 스크립트
    public FollowCamera followCamera;

    // 남은 시간.
    public float timeRemaining = 5.0f * 60.0f;
    // 게임 오버 플래그.
    public bool gameOver = false;
    // 게임 클리어 플래그.
    public bool gameClear = false;
    // 씬 전환 시간.
    public float sceneChangeTime = 3.0f;

    //public AudioClip clearSeClip;
    //AudioSource clearSeAudio;
    /*
    void Start()
    {
        // 오디오 초기화.
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
    }
    */
    void Update()
    {
        // 플레이어 등장
        if (player == null && (Network.isServer || Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5f, 0, 0);
            player = Network.Instantiate(playerPrefab, startPoint.position + shiftVector, startPoint.rotation, 0) as GameObject;
            followCamera.lookTarget = player.transform;

            // 이름 송신
            NetworkManager networkManager = FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
            player.GetComponent<NetworkView>().RPC("SetName", RPCMode.AllBuffered, networkManager.GetPlayerName());
        }

        // 게임 종료 조건 성립 후 씬 전환.
        if (gameOver || gameClear)
        {
            sceneChangeTime -= Time.deltaTime;
            if (sceneChangeTime <= 0.0f)
            {
                SceneManager.LoadScene("TitleScene");
            }
            return;
        }

        // 게임이 시작되면 타이머를 움직인다.
        if(Network.isServer || Network.isClient)
        {
            timeRemaining -= Time.deltaTime;
            // 남은 시간이 없으면 게임 오버.
            if (timeRemaining <= 0.0f)
            {
                GameOver();
            }
        } 
    }

    // 게임 오버
    public void GameOver()
    {
        if (!gameOver && Network.isServer)
            GetComponent<NetworkView>().RPC("GameOverOnNetwork", RPCMode.AllBuffered);                
    }

    [RPC]
    void GameOverOnNetwork()
    {
        gameOver = true;
    }

    public void GameClear()
    {
        if (!gameClear && Network.isServer)
            GetComponent<NetworkView>().RPC("GameClearOnNetwork", RPCMode.AllBuffered);        
    }

    [RPC]
    void GameClearOnNetwork()
    {
        gameClear = true;
    }

    [RPC]
    void SetRemainTime(float time)
    {
        timeRemaining = time;
    }

    // 다른 플레이어가 접속해 오면 호출된다
    // 이 함수가 호출되는 것은 서버 컴퓨터뿐이다.
    private void OnPlayerConnected(NetworkPlayer player)
    {
        GetComponent<NetworkView>().RPC("SetRemainTime", player, timeRemaining);
    }

}