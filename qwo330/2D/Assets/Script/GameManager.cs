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

    private void OnGUI()
    {
        GUI.Label(new Rect(8f, 8f, 128f, 48f), new GUIContent(playTime.ToString("0"), TimerIcon), TimerLabelStyle);
    }

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        enemy = GameObject.FindWithTag("Enemy").GetComponent<EnemyController>();
        MaxLife = player.GetPlayerMaxLife();
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
        SceneManager.LoadScene("MainGame");
    }
}
