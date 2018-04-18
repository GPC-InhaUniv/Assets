using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneCtrl : MonoBehaviour {

    public Texture2D bgTexture;

    private void OnGUI()
    {

        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);

        //해상도 대응
        GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(Screen.width / 854.0f, Screen.height / 480.0f, 1.0f));
        // 타이틀 화면 텍스쳐 표시
        GUI.DrawTexture(new Rect(0.0f, 0.0f, 854.0f, 480.0f), bgTexture);

        //시작 버튼을 만든다.
        if(GUI.Button(new Rect(327, 290, 200, 54), "Start", buttonStyle))
        {
            //Application.LoadLevel("GameScene");
            SceneManager.LoadScene("GameScene");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
