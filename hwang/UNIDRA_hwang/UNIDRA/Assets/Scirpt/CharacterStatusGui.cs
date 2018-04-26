using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatusGui : MonoBehaviour {


    float baseWidth = 854f;
    float baseHeight = 480;

    
    CharacterStatus playerStatus;
    Vector2 playerStatusOffset = new Vector2(8f, 80f);

    Rect nameRect = new Rect(0f, 0f, 120f, 24f);
    public GUIStyle nameLabelStyle;

    public Texture backLifeBarTexture;
    public Texture frontLifeBarTexture;
    float frontLifeBarOffsetX = 2f;
    float lifeBarTextureWidth = 128f;
    Rect playerLifeBarRect = new Rect(0f, 0f, 128f, 16f);
    Color playerFrontLifeBarColor = Color.green;
    Rect enemyLifeBarRect = new Rect(0f, 0f, 128f, 24f);
    Color enemyFrontLifeBarColor = Color.red;


    //플레이어 스테이터스 표시 // 
    void DrawPlayerStatus()
    {
        float x = baseWidth - playerLifeBarRect.width - playerStatusOffset.x;
        float y = playerStatusOffset.y;
        float delta_height = nameRect.height + playerLifeBarRect.height;
        PlayerCtrl[] players = FindObjectsOfType<PlayerCtrl>() as PlayerCtrl[];

        foreach (PlayerCtrl player in players)
        {
            CharacterStatus status = player.GetComponent<CharacterStatus>();
            if (status != null)
            {
                DrawCharacterStatus(
            x, y,
            status,
            playerLifeBarRect,
            playerFrontLifeBarColor);
                y += delta_height;
                
            }
        }
    }




    void DrawCharacterStatus(float x, float y , CharacterStatus status, Rect bar_rect, Color front_color)
    {
        GUI.Label(
            new Rect(x, y, nameRect.width, nameRect.height),
            status.characterName,
            nameLabelStyle);

        float lifeValue = (float)status.Hp / status.MaxHp;
        if(backLifeBarTexture != null)
        {
            y += nameRect.height;
            GUI.DrawTexture(new Rect(x, y, bar_rect.width, bar_rect.height), backLifeBarTexture);
        }

        if(frontLifeBarTexture != null)
        {
            float resizeFrontBarOffsetX = frontLifeBarOffsetX * bar_rect.width / lifeBarTextureWidth;
            float frontBarWidth = bar_rect.width - resizeFrontBarOffsetX * 2;

            var guiColor = GUI.color;
            GUI.color = front_color;
            GUI.DrawTexture(new Rect(x + resizeFrontBarOffsetX, y, frontBarWidth * lifeValue, bar_rect.height), frontLifeBarTexture);
            GUI.color = guiColor;
        }
    }
    void DrawEnemyStatus()
    {
        if (playerStatus.lastAttackTarget != null)
        {
            CharacterStatus targetStatus = playerStatus.lastAttackTarget.GetComponent<CharacterStatus>();
            DrawCharacterStatus(
                (baseWidth - enemyLifeBarRect.width) / 2.0f, 0f,
                targetStatus,
                enemyLifeBarRect,
                enemyFrontLifeBarColor);
        }
    }


    void OnGUI()
    {
        // 해상도 대응.
        GUI.matrix = Matrix4x4.TRS(
            Vector3.zero,
            Quaternion.identity,
            new Vector3(Screen.width / baseWidth, Screen.height / baseHeight, 1f));

        GameRuleCtrl gameRuleCtrl = FindObjectOfType(typeof(GameRuleCtrl)) as GameRuleCtrl;
        if (gameRuleCtrl.player != null)
        {
            playerStatus = gameRuleCtrl.player.GetComponent<CharacterStatus>();
            // 스테이터스.
            DrawPlayerStatus();
            DrawEnemyStatus();
        }
    }


}
