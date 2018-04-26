using UnityEngine;
using System.Collections;

public class GameRuleCtrl : MonoBehaviour
{
    // 남은 시간.
    public float timeRemaining = 5.0f * 60.0f;
    // 게임 오버 플래그.
    public bool gameOver = false;
    // 게임 클리어 플래그.
    public bool gameClear = false;
    // 씬 전환 시간.
    public float sceneChangeTime = 3.0f;
    
    #pragma warning disable 618

    ////////////서버에서 객체들을 생성하기 위한 변수들/////////////
    //자신의 컴퓨터에 있는 플레이어 게임 오브젝트
    public GameObject player;
    //실체화되는 플레이어의 프리팹
    public GameObject playerPrefab;
    //시작위치
    public Transform startPoint;
    //FollowCamera 스크립트
    public FollowCamera followCamera;

    public AudioClip clearSeClip;
    AudioSource clearSeAudio;

    private void Start()
    {
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
    }

    void Update()
    {
        if (player == null && (Network.isServer || Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5F, 0, 0);
            player = Network.Instantiate(playerPrefab, startPoint.position + shiftVector, startPoint.rotation, 0) as GameObject;

            followCamera.lookTarget = player.transform;

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

        if(Network.isServer || Network.isClient)
        {
            timeRemaining -= Time.deltaTime;
            // 남은 시간이 없으면 게임 오버.
            if (timeRemaining <= 0.0f)
            {
                GameOver();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    public void GameOver()
    {
        if (!gameOver && Network.isServer)
            GetComponent<NetworkView>().RPC("GameOverNetwork", RPCMode.AllBuffered);
    }
    [RPC]
    void GameOverNetwork()
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

        if (!gameClear && Network.isServer)
            GetComponent<NetworkView>().RPC("GameClearOnNetwork", RPCMode.AllBuffered);
    }
    [RPC]
    void GameClearOnNetwork()
    {
        gameClear = true;
    }
}
