using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkManager : MonoBehaviour {

    const string GameTypeName = "UNIDRA";

    //로컬 ip 주소와 포트
    const string LocalServerIP = "127.0.0.1";
    const int ServerPort = 25000;

    string playerName;
    string gameServerName;

    private void Start()
    {
        playerName = "Player" + Random.Range(0, 99999999).ToString();
        gameServerName = "Server" + Random.Range(0, 99999999).ToString();
        UpdateHostList();
    }

    public enum Status
    {
        NoError,
        LaunchingServer,
        ServerLaunched,
        LaunchServerFailed,
        ConnectingToServer,
        ConnectedToServer,
        ConnectToServerFailed,
        DistConnectedFromServer,
    };

    Status _status = Status.NoError;
    public Status status { get { return _status; } private set { _status = value; } }

    //서버를 실행한다.
    public void LaunchServer(string roomName)
    {
        status = Status.LaunchingServer;
        StartCoroutine(LaunchServerCoroutine(gameServerName));
    }

    bool useNat = false;
    IEnumerator CheckNat()
    {
        // 접속 테스트가 끝났는가
        bool doneTesting = false;
        bool probingPublicIP = false;
        float timer = 0;
        useNat = false;

        // 접속 테스트를 해서 NAT 펀치스루가 필요한지 조사한다.
        while (!doneTesting)
        {
            // 반환값에 따라 NAT 펀치스루가 필요한지, 아직 조사 중인지, 오류인지 판단한다.
            ConnectionTesterStatus connectionTestResult = Network.TestConnection();
            switch (connectionTestResult)
            {
                case ConnectionTesterStatus.Error://에러 발생
                    doneTesting = true;
                    break;
                case ConnectionTesterStatus.Undetermined: // 조사 중
                    doneTesting = false;
                    break;
                case ConnectionTesterStatus.PublicIPIsConnectable: // 공인 ip 주소가 있으니 NAT 펀치스루는 사용하지 않아도 된다.
                    useNat = false;
                    doneTesting = true;
                    break;
                case ConnectionTesterStatus.PublicIPPortBlocked: // 공인 ip 주소가 있지만 포트가 차단되어 접속할 수 없다.
                    useNat = false;
                    if (!probingPublicIP)
                    {
                        connectionTestResult = Network.TestConnectionNAT();
                        probingPublicIP = true;
                        timer = Time.time + 10;
                    }
                    else if (Time.time > timer)
                    {
                        //reset
                        probingPublicIP = false;
                        useNat = true;
                        doneTesting = true;
                    }
                    break;
                case ConnectionTesterStatus.PublicIPNoServerStarted: // 공인 ip 주소가 있지만 서버가 시작하지 않았다.
                    break;
                case ConnectionTesterStatus.LimitedNATPunchthroughPortRestricted:
                case ConnectionTesterStatus.LimitedNATPunchthroughSymmetric:
                    // NAT 펀치스루에 제한이 있다.
                    // 서버에 접속할 수 없는 클라이언트가 있을지도 모른다.
                    useNat = true;
                    doneTesting = true;
                    break;
                case ConnectionTesterStatus.NATpunchthroughAddressRestrictedCone:
                case ConnectionTesterStatus.NATpunchthroughFullCone:
                    // NAT 펀치스루로 서버와 클라이언트는 문제없이 접속할 수 있다.
                    useNat = true;
                    doneTesting = true;
                    break;
                default:
                    Debug.Log("Error in test routine, got" + connectionTestResult);
                    break;
            }
            yield return null;
        }
    }

    IEnumerator LaunchServerCoroutine(string roomName)
    {
        yield return StartCoroutine(CheckNat());

        // 서버를 실행한다.
        NetworkConnectionError error = Network.InitializeServer(32, ServerPort, useNat);
        if(error != NetworkConnectionError.NoError)
        {
            Debug.Log("Can't Launch Server");
            status = Status.LaunchServerFailed;
        }
        else
        {
            // 마스터 서버에 게임 서버를 등록한다.
            MasterServer.RegisterHost(GameTypeName, gameServerName);
        }

    }
    // 서버에 접속한다.
    public void ConnectToServer(string serverGuid, bool connectLocalServer)
    {
        status = Status.ConnectingToServer;
        if (connectLocalServer)
            Network.Connect(LocalServerIP, ServerPort);
        else
            Network.Connect(serverGuid);
    }
    // 서버가 실행되었다.
    private void OnServerInitialized()
    {
        status = Status.ServerLaunched;
    }

    //서버에 접속했다.
    private void OnConnectedToServer()
    {
        status = Status.ConnectedToServer;
    }

    private void OnFailedToConnect(NetworkConnectionError error)
    {
        Debug.Log("FailedToConnect : " + error.ToString());
        status = Status.ConnectToServerFailed;
    }

    // 플레이어가 끊었다. ( 서버가 동작하는 컴퓨터에서 호출된ㄷ.)
    private void OnPlayerDisconnected(NetworkPlayer player)
    {
        Network.RemoveRPCs(player);
        Network.DestroyPlayerObjects(player);
    }

    // 서버에서 끊어졌다
    private void OnDisconnectedFromServer(NetworkDisconnection info)
    {
        Debug.Log("DisconnectedFromServer : " + info.ToString());
        status = Status.DistConnectedFromServer;
        SceneManager.LoadScene("TitleScene");
    }

    public Status GetStatus()
    { return status; }

    public string GetPlayerName() { return playerName; }

    //private void OnDestroy()
    //{
    //    if(Network.isServer)
    //    {
    //        MasterServer.UnregisterHost();
    //        Network.Disconnect();
    //    }
    //}

    // ======== 로비 관련 ============
    // 마스터 서버에 등록된 게임 서버 목록을 갱신한다.
    public void UpdateHostList()
    {
        MasterServer.ClearHostList();
        MasterServer.RequestHostList(GameTypeName);
    }

    public HostData[] GetHostList()
    {
        return MasterServer.PollHostList();
    }

    void SetMasterServerAndNatFacilitatorIP(string masterServerAddress, string facilitatorAddress)
    {
        MasterServer.ipAddress = masterServerAddress;
        Network.natFacilitatorIP = facilitatorAddress;
    }

    // 마스터 서버에 등록한 서버를 삭제한다.
    public void UnregisterHost()
    {
        MasterServer.UnregisterHost();
    }

    // ========= GUI 설정 =============
    private void OnGUI()
    {
        if ((Network.isServer || Network.isClient)) return;

        // 높이 480의 중심0,0을 기준으로 한다.
        float scale = Screen.height / 480.0f;
        GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0), Quaternion.identity,
            new Vector3(scale, scale, 1.0f));
        GUI.Window(0, new Rect(-200, -200, 400, 400), NetworkSettingWindow, "Network Setting");
    }

    Vector2 scrollPosition;
    void NetworkSettingWindow(int windowID)
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label("Player name : ");
        playerName = GUILayout.TextField(playerName, 32);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Game Server Name : ");
        gameServerName = GUILayout.TextField(gameServerName, 32);
        GUILayout.EndHorizontal();

        // 게임 서버를실행한다.
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("Launch"))
            LaunchServer(gameServerName);
        GUILayout.EndHorizontal();
        GUILayout.Space(20);

        // 게임서버 목록
        GUILayout.BeginHorizontal();
        GUILayout.Label("Game Server List (Click To Connect):");
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("Refresh"))
            UpdateHostList();
        GUILayout.EndHorizontal();
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(380), GUILayout.Height(200));

        // 서버 목록 취득
        HostData[] hosts = GetHostList();
        if (hosts.Length > 0)
        {
            foreach (HostData host in hosts)
                if (GUILayout.Button(host.gameName, GUI.skin.box, GUILayout.Width(360)))
                    ConnectToServer(host.guid, false);
        }
        else
            GUILayout.Label("No Server");
        GUILayout.EndScrollView();

        // 로컬 서버에 접속한다.
        if(GUILayout.Button("Connect Local Server"))
        {
            ConnectToServer("", true);
        }

        GUILayout.Label("Status: " + status.ToString());
    }
}
