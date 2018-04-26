using UnityEngine;
using System.Collections;

public class GameBossEmergenceGui : MonoBehaviour
{
    GameRuleCtrl gameRuleCtrl;

    float baseWidth = 854f;
    float baseHeight = 480f;

    public Texture2D bossEmergenceTexture;
 
    void Awake()
    {
        gameRuleCtrl = GameObject.FindObjectOfType(typeof(GameRuleCtrl)) as GameRuleCtrl;
    }

    void OnGUI()
    {
        Texture2D aTexture;
        if (gameRuleCtrl.bossEmergence)
        {
            aTexture = bossEmergenceTexture;
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

        if(gameRuleCtrl.bossEmergence)
        StartCoroutine(ShowWarningText());
        GUI.DrawTexture(new Rect(0.0f, 150.0f, 854.0f, 64.0f), aTexture);
    }

    IEnumerator ShowWarningText()
    {
        int count = 0;

        while(true)
        {
            if (count > 3)
            {
                gameRuleCtrl.bossEmergence = false;
                gameRuleCtrl.MainCamera.GetComponent<Camera>().enabled = true;
                gameRuleCtrl.SubCamera.GetComponent<Camera>().enabled = false;
                yield break;
            }
                count++;
                yield return new WaitForSeconds(1.0f);
         
        }
    }
}
