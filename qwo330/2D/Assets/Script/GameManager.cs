using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    private static GameManager _gameManager = null;

    public static GameManager gameManager
    {
        get
        {
            if (_gameManager == null)
            {
                _gameManager = FindObjectOfType(typeof(GameManager)) as GameManager;
                if (_gameManager == null)
                    Debug.Log("GameManager가 없어서 할당 불가능");
            }
            return _gameManager;
        }
    }

    float MaxLife;
    float playTime = 0.0f;
    PlayerController player;
    EnemyController enemy;

    public Texture TimerIcon;
    public GUIStyle TimerLabelStyle;
    public Image LifeBar;
    public GameObject GameOverPanel;

    public string userID;
    public int characterType;

    public GameDataCtrl gameData;
    public Text playerName;
    public SpriteRenderer playerHP;

    private void OnGUI()
    {
        GUI.Label(new Rect(8f, 8f, 128f, 48f), new GUIContent(playTime.ToString("0"), TimerIcon), TimerLabelStyle);
    }

    private void Awake()
    {
        gameData = GameObject.FindWithTag("Data").GetComponent<GameDataCtrl>();
        gameData.GetData(out userID, out characterType);

        switch(characterType)
        {
            case 1:
                Instantiate(Resources.Load("Prefabs\\Player1"));
                break;
            case 2:
                Instantiate(Resources.Load("Prefabs\\Player2"));
                Debug.Log(2);
                break;
            default:
                Instantiate(Resources.Load("Prefabs\\Player1"));
                break;
        }
    }

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        MaxLife = player.GetPlayerMaxLife();

        enemy = GameObject.FindWithTag("Enemy").GetComponent<EnemyController>();
        playerName = GameObject.FindWithTag("PlayerText").GetComponent<Text>();
        playerName.text = userID;
        playerHP = GameObject.FindWithTag("PlayerHP").GetComponent<SpriteRenderer>();
        //playerHP.
    }
	
	// Update is called once per frame
	void Update () {
        playTime += Time.deltaTime;
        LifeBar.fillAmount = player.Life / MaxLife;
        if (player.Life <= 0) GameOver();
    }

    void GameOver()
    {
        GameOverPanel.SetActive(true);
        enemy.GameOver();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("Login");
    }
}
