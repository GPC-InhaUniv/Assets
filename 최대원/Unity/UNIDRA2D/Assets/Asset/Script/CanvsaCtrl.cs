using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvsaCtrl : MonoBehaviour {

    MainSettingCtrl mainSetting;

    private void Start()
    {
        mainSetting = FindObjectOfType<MainSettingCtrl>();
    }

    public void OnSelectBlue(Button button)
    {
        mainSetting.PlayerChar = 0;
        Debug.Log("blue");
        Debug.Log("blue : " + button.name);
    }

    public void OnSelectPurple(Button button)
    {
        mainSetting.PlayerChar = 1;
        Debug.Log("Purple");
        Debug.Log("Purple : " + button.name);
    }

    public void OnEndEdit(InputField inputField)
    {
        mainSetting.PlayerName = inputField.text;
        Debug.Log(inputField.text);
    }

    public void OnStartButton(Button button)
    {
        if(mainSetting.PlayerName != "")
        SceneManager.LoadScene(1);
    }
}
