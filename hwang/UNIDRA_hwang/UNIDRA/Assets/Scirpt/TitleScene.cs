using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour {


    public Texture2D bgTexture;

    private void OnGUI()
    {
        GUIStyle buttonStyle  = new GUIStyle (GUI.skin.button);

        GUI.matrix = Matrix4x4.TRS(
            Vector3.zero,
            Quaternion.identity,
            new Vector3(Screen.width / 854.0f, Screen.height / 480.0f, 1.0f));

        GUI.DrawTexture(new Rect(0.0f, 0.0f, 854.0f, 480.0f), bgTexture);

        if(GUI.Button(new Rect(327, 290, 200, 54), "Start", buttonStyle))
        {
            SceneManager.LoadScene("UNIDRA");
        }
    }
}
