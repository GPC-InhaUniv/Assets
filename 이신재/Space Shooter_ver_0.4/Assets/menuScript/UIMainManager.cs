using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainManager : MonoBehaviour {

	public void StartGame()
    {
        Application.LoadLevel("MainGame");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
