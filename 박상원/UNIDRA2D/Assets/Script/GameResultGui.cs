using UnityEngine;
using System.Collections;

public class GameResultGui : MonoBehaviour
{
	GameRuleCtrl gameRuleCtrl;

	float baseWidth = 854f;
	float baseHeight = 480f;

	public Texture2D gameOverTexture;
	public Texture2D gameClearTexture;
	
	void Awake()
	{
		gameRuleCtrl = GameObject.FindObjectOfType(typeof(GameRuleCtrl)) as GameRuleCtrl;
	}
	
	void OnGUI()
	{
        
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
		Texture2D aTexture;

		if( gameRuleCtrl.gameClear )
		{
			aTexture = gameClearTexture;
		}
		else if( gameRuleCtrl.gameOver )
		{
			aTexture = gameOverTexture;
		}
		else
		{
			return;
		}

		// 해상도 대응.
		GUI.matrix = Matrix4x4.TRS(
			Vector3.zero,
			Quaternion.identity,
			new Vector3(Screen.width / baseWidth, Screen.height / baseHeight, 1f));
		
		// 결과.
		GUI.DrawTexture(new Rect(280.0f, 180.0f, 300.0f, 124.0f), aTexture);

        // 게임 종료 버튼을 만든다.
        if(GUI.Button(new Rect(350,290,160,34),"게임 종료",buttonStyle))
        {
            Application.Quit();
        }
	}
}
