using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSettingCtrl : MonoBehaviour
{
    public int PlayerChar;
    public string PlayerName;

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(this);
        PlayerChar = 0;
        PlayerName = "";
    }
}
