﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimerGui : MonoBehaviour {

    GameRuleCtrl gameRuleCtrl;

    float baseWidth = 854f;
    float baseHeight = 480f;

    public Texture timerIcon;
    public GUIStyle timerLabelStyle;

    private void Awake()
    {
        gameRuleCtrl = FindObjectOfType(typeof(GameRuleCtrl)) as GameRuleCtrl;
    }

    private void OnGUI()
    {
        GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity,
            new Vector3(Screen.width / baseWidth, Screen.height / baseHeight, 1f));

        GUI.Label(new Rect(8f, 8f, 128f, 48f),
            new GUIContent(gameRuleCtrl.timeRemaining.ToString("0"), timerIcon), timerLabelStyle);
    }
}
