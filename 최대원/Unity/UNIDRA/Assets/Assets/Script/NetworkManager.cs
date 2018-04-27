using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkManager : MonoBehaviour
{
    const string GameTpyeName = "choi's_game";
    const string LocalServerIP = "127.0.0.1";
    const int ServerPort = 25000;

    string playerName;
    string gameServerName;

    private void Start()
    {
        playerName = "Player" + Random.Range(0, 9999).ToString();
        gameServerName = "Server" + Random.Range(0, 9999).ToString();

    }

    public enum Status
    {
        NoError, //오류 없음
        LaunchingServer, //서버 실행 중
        ServerLaunched, //서버 실행 성공
        LaunchServerFailed, //서버 실행 실패
        ConnectingToServer, //서버 연결 중
        ConnectedToServer, //서버 접속 성공
        ConnectToServerFailed, //서버 접속 실패
        DisconnectecdFromServer, //서버 연결 끊킴
    };

    Status _status = Status.NoError;
    public Status status
    {
        get
        {
            return _status;
        }
        private set
        {
            _status = value;
        }
    }

    public void LaunchServer(string roomName)
    {
        status = Status.LaunchingServer;
        StartCoroutine(LaunchServercoroutune(gameServerName));
    }

    bool useNat = false;
    IEnumerator checkNat()
    {
        bool doneTesting = false; //테스트가 끝났는지 여부 확인
        bool probingPubilcIP = false;
        float timer = 0;
        useNat = false;

        while (!doneTesting)
        {
            ConnectionTesterStatus connectionTestResult = Network.TestConnection();
            switch (connectionTestResult)
            {
                case ConnectionTesterStatus.Error:
                    doneTesting = true;
                    break;

                case ConnectionTesterStatus.Undetermined: //조사 중
                    doneTesting = false;
                    break;

                case ConnectionTesterStatus.PublicIPIsConnectable: //공인 IP 주소가 있으므로 nat 펀치스루 미사용
                    doneTesting = true;
                    useNat = false;
                    break;

                case ConnectionTesterStatus.PublicIPPortBlocked: //포트 차단됨
                    useNat = false;
                    if (!probingPubilcIP)
                    {
                        connectionTestResult = Network.TestConnectionNAT();
                        probingPubilcIP = true;
                        timer = Time.time + 10;
                    }
                    else if (Time.time > timer)
                    { //reset
                        probingPubilcIP = false;
                        useNat = true;
                        doneTesting = true;
                    }
                    break;

                case ConnectionTesterStatus.PublicIPNoServerStarted: //서버가 시작되지 않음
                    break;

                case ConnectionTesterStatus.LimitedNATPunchthroughPortRestricted: //펀치스루에 제한이 없음
                case ConnectionTesterStatus.LimitedNATPunchthroughSymmetric: //접속 불가능한 클라이언트가 있을지도 모르는 상태
                    useNat = true;
                    doneTesting = true;
                    break;

                case ConnectionTesterStatus.NATpunchthroughAddressRestrictedCone:
                case ConnectionTesterStatus.NATpunchthroughFullCone:
                    //서버와 클라이언트가 문제없이 접속 가능한 상태
                    useNat = true;
                    doneTesting = true;
                    break;

                default:
                    Debug.Log("에러 테스트 결과 : " + connectionTestResult);
                    break;
            }
            yield return null;
        }
    }

    IEnumerator LaunchServercoroutune(string roonName)
    {
        yield return StartCoroutine(checkNat());

        //서버 실행
        NetworkConnectionError error = Network.InitializeServer(32, ServerPort, useNat);
        if (error != NetworkConnectionError.NoError)
        {
            Debug.Log("서버를 실행 할 수 없음");
            status = Status.LaunchServerFailed;
        }
        else
        {
            MasterServer.RegisterHost(GameTpyeName, gameServerName);
        }
    }

    public void ConnectToServer(string serverGuid, bool connectLocalServer)
    {
        status = Status.ConnectingToServer;
        if (connectLocalServer)
        {
            Network.Connect(LocalServerIP, ServerPort);
        }
        else
        {
            Network.Connect(serverGuid);
        }
    }

    //이하 상태변경
    private void OnServerInitialized()
    {
        status = Status.ServerLaunched;
    }

    private void OnConnectedToServer()
    {
        status = Status.ConnectedToServer;
    }

    private void OnFailedToConnect(NetworkConnectionError error)
    {
        Debug.Log("서버 연결 실패! :" + error.ToString());
        status = Status.ConnectToServerFailed;
    }

    //플레이어가 서버 연결을 끊음
    private void OnPlayerDisconnected(NetworkPlayer player)
    {
        Network.RemoveRPCs(player);
        Network.DestroyPlayerObjects(player);
    }

    //서버로부터 연결이 끊어짐
    private void OnDisconnectedFromServer(NetworkDisconnection info)
    {
        Debug.Log("서버로 부터 연결이 헤제되었습니다. : " + info.ToString());
        status = Status.DisconnectecdFromServer;
        SceneManager.LoadScene(0);
    }

    //상태 획득
    public Status GetStatus()
    {
        return status;
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    private void OnDestroy()
    {
        if (Network.isServer)
        {
            MasterServer.UnregisterHost();
            Network.Disconnect();
        }
    }

    //===========로비 관련============
    public void UpdateHostList()
    {
        MasterServer.ClearHostList();
        MasterServer.RequestHostList(GameTpyeName);
    }

    public HostData[] GetHostList()
    {
        return MasterServer.PollHostList();
    }

    //마스터 서버와 nat 퍼실리데이터의 ip 주소 설정
    void SetMasterServerAndNatFacilitatorIP(string masterServerAddress, string facilitatorAddress)
    {
        MasterServer.ipAddress = masterServerAddress;
        Network.natFacilitatorIP = facilitatorAddress;
    }

    public void UnregisterHost()
    {
        MasterServer.UnregisterHost();
    }

    //===========설정 GUI============
    private void OnGUI()
    {
        if ((Network.isServer || Network.isClient))
            return;

        float scale = Screen.height / 480f;
        GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0), Quaternion.identity, new Vector3(scale, scale, 1f));
        GUI.Window(0, new Rect(-200, -200, 400, 400), NetworkSettingWindow, "Network Setting");
    }

    Vector2 scrollPosition;

    void NetworkSettingWindow(int windowID)
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label("Player Name : ");
        playerName = GUILayout.TextField(playerName, 32);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Game Server Name : ");
        gameServerName = GUILayout.TextField(gameServerName, 32);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("실행"))
        {
            LaunchServer(gameServerName);
        }
        GUILayout.EndHorizontal();
        GUILayout.Space(20);

        GUILayout.BeginHorizontal();
        GUILayout.Label("Game Server List : ");
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("새로고침"))
        {
            UpdateHostList();
        }
        GUILayout.EndHorizontal();
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(380), GUILayout.Height(200));

        HostData[] hosts = GetHostList();
        if(hosts.Length > 0)
        {
            foreach (HostData host in hosts)
            {
                if(GUILayout.Button(host.gameName, GUI.skin.box, GUILayout.Width(360)))
                {
                    ConnectToServer(host.guid, false);
                }
            }
        }
        else
        {
            GUILayout.Label("접속 가능한 서버가 없습니다.");
        }
        GUILayout.EndScrollView();

        if(GUILayout.Button("서버에 접속하기"))
        {
            ConnectToServer("", true);
        }

        GUILayout.Label("상태 : " + status.ToString());
    }
}
