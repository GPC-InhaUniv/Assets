using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeGui : MonoBehaviour
{
    //GameRuleCtrl gameRuleCtrl;
    PlayerController playerCtrl;

    float baseWidth = 854f;
    float baseHeight = 480f;

    public Texture playerLife;
    public GUIStyle LifeLabelStyle;

    void Awake()
    {
        //gameRuleCtrl = GameObject.FindObjectOfType(typeof(GameRuleCtrl)) as GameRuleCtrl;
        playerCtrl = GameObject.FindObjectOfType(typeof(PlayerController)) as PlayerController;
    }

    void OnGUI()
    {
        // 해상도 대응.
        GUI.matrix = Matrix4x4.TRS(
            Vector3.zero,
            Quaternion.identity,
            new Vector3(Screen.width / baseWidth, Screen.height / baseHeight, 1f));

        // 캐릭터 목숨
        GUI.Label(
            new Rect(788f,0f, 128f, 48f),
            new GUIContent(playerCtrl.HP.ToString("0"), playerLife),
            LifeLabelStyle);
    }
}
