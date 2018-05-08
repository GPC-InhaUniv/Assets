using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoginManager : MonoBehaviour {

    public Canvas canvas;
    GraphicRaycaster gr;
    PointerEventData ped;

    public InputField ID_Field;
    public GameObject LogInPanel, CharacterSelectPanel;

    public GameDataCtrl gameData;

    string userID;
    int characterType;
    bool SelectComplete;

    private void Start()
    {
        gameData = GameObject.FindWithTag("Data").GetComponent<GameDataCtrl>();
        gr = canvas.GetComponent<GraphicRaycaster>();
        ped = new PointerEventData(null);
        SelectComplete = false;
    }

    private void Update()
    {
        if (CharacterSelectPanel.activeSelf)
        {
            SelectCharacter();
            if (SelectComplete)
            {
                gameData.SetData(userID, characterType);
                SceneManager.LoadScene("MainGame");
            }
        }
    }

    public void LogIn()
    {
        userID = ID_Field.text.ToString();
        Debug.Log(userID);
        if (!"".Equals(userID)) // 입력 값이 없으면 실행하지 않음
        {
            CharacterSelectPanel.SetActive(true);
            LogInPanel.SetActive(false);
        }
    }

    public void SelectCharacter()
    {
        ped.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        gr.Raycast(ped, results);
        if (results.Count != 0)
        {
            GameObject hitObj = results[0].gameObject;
            //Debug.Log(hitObj.name.Substring(6));
            if (Input.GetMouseButtonDown(0))
            {
                int.TryParse(hitObj.name.Substring(6), out characterType); // player 다음부터 출력
                SelectComplete = true;
            }
        }
    }
}
