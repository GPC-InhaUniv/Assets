using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneCtrl : MonoBehaviour {

    public Texture2D bgTexture;

    private void OnGUI()
    {
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(Screen.width / 854f, Screen.height / 480f, 1f));
        GUI.DrawTexture(new Rect(0f, 0f, 854f, 480f), bgTexture);

        if(GUI.Button(new Rect(327,290,200,54),"start", buttonStyle))
        {
            SceneManager.LoadScene(1);
        }
    }
}
