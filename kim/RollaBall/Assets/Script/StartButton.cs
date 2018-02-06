using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour {

	public void Startgame()
    {

        SceneManager.LoadScene("Main");
    }
    
    public void Endgame()
    {
        Application.Quit();
    }
}
