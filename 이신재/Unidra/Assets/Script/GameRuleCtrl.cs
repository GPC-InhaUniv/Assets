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


    public AudioClip clearSeClip;
    AudioSource clearSeAudio;
    public GameObject player;
    public GameObject playerPrefab;
    public Transform startPoint;
    public FollowCamera followCamera;
    NetworkView networkView;

    void Start()
    {
        // 오디오 초기화.
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
        networkView = GetComponent<NetworkView>();
    }

    void Update()
    {
        if (player == null && (Network.isServer || Network.isClient))
        {
            Vector3 shiftVector = new Vector3(Network.connections.Length * 1.5f, 0, 0);
            player = Network.Instantiate(playerPrefab, startPoint.position +
                shiftVector, startPoint.rotation, 0) as GameObject;
            followCamera.lookTarget = player.transform;
            //이름송신
            NetworkManager networkManager =
                FindObjectOfType(typeof(NetworkManager)) as NetworkManager;
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
    void GameOverOnNetwork()
    {
        gameOver = true;
    }
    public void GameClear()
    {
        if (!gameClear && Network.isServer)
            networkView.RPC("GameClearOnNetwork", RPCMode.AllBuffered);
        

        // 오디오 재생.
        //clearSeAudio.Play();
    }
    [RPC]
    void GameClearOnNetwork()
    {
        gameClear = true;
    }
    void GetRemainTime(float time)
    {
        timeRemaining = time;
    }
    private void OnPlayerConnected(NetworkPlayer player)
    {
        networkView.RPC("SetRemainTime",player, timeRemaining);
    }
}



