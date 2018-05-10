using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRuleCtrl : MonoBehaviour
{

    float baseWidth = 854f;
    float baseHeight = 480f;

    public Texture timerIcon;
    public GUIStyle timerLabelStyle;

    // Use this for initialization
    public float time = 1f;
    public GameObject[] DragonArray;
    public int CurrentDragon = 0;
    public int MaxDragonCount = 3;
    public GameObject DragonPrefab;
    public PlayerStatus playerStatus;
    public GameObject gameOverImage;
    bool gameover = false;



    private void Start()
    {
        DragonArray = new GameObject[MaxDragonCount];
        StartCoroutine(LevelUp());
        StartCoroutine(MakeNewDragon());
    }
    private void Update()
    {
        if (playerStatus.HP > 0)
            time += Time.deltaTime;
        else
        {
            if (!gameover)
            {
                gameOverImage.GetComponent<SpriteRenderer>().sortingOrder = 2;
                gameover = true;
            }
        }

    }

    IEnumerator LevelUp()
    {


        while (true)
        {
            if (playerStatus.HP <= 0)
                yield break;

            for (int i = 0; i < CurrentDragon; i++)
                DragonArray[i].GetComponent<EnemyController>().IncreaseDifficulty();
            yield return new WaitForSeconds(3f);
        }
    }
    IEnumerator MakeNewDragon()
    {
        while (true)
        {

            if (playerStatus.HP <= 0)
                yield break;

            DragonArray[CurrentDragon] = Instantiate(DragonPrefab, transform.position, transform.rotation);
            CurrentDragon++;
            if (CurrentDragon >= MaxDragonCount)
                yield break;

            yield return new WaitForSeconds(10f);
        }
    }
    void OnGUI()
    {
        if (playerStatus.HP <= 0)
            return;

            // 해상도 대응.
            GUI.matrix = Matrix4x4.TRS(
            Vector3.zero,
            Quaternion.identity,
            new Vector3(Screen.width / baseWidth, Screen.height / baseHeight, 1f));

        // 타이머.
        GUI.Label(
            new Rect(8f, 8f, 128f, 48f),
            new GUIContent(time.ToString("0"), timerIcon),
            timerLabelStyle);
    }
}
