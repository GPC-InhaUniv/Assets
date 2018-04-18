using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRuleCtrl : MonoBehaviour {

    public float sceneChangeTime = 3.0f;
    public float timeRemaining = 5.0f * 60.0f;
    public bool gameOver = false;
    public bool gameClear = false;

    public AudioClip clearSeClip;
    AudioSource clearSeAudio;

    private void Start()
    {
        clearSeAudio = gameObject.AddComponent<AudioSource>();
        clearSeAudio.loop = false;
        clearSeAudio.clip = clearSeClip;
    }

    // Update is called once per frame
    void Update () {
        if(gameOver || gameClear)
        {
            sceneChangeTime -= Time.deltaTime;
            if(sceneChangeTime <= 0.0f)
            {
                SceneManager.LoadScene("TitleScene");
            }
            return;
        }
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0.0f)
            GameOver();
	}

    public void GameOver()
    {
        gameOver = true;
        Debug.Log("GameOver");
    }

    public void GameClear()
    {
        gameClear = true;
        clearSeAudio.Play();
        Debug.Log("GameClear");
    }
}
