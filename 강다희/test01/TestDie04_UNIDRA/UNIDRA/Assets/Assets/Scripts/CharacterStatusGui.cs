using UnityEngine;
using System.Collections;

public class CharacterStatusGui : MonoBehaviour
{
    private float baseWidth = 854f;
    private float baseHeight = 480f;

    // 스테이터스.
    private CharacterStatus playerStatus;

    private Vector2 playerStatusOffset = new Vector2(8f, 80f);

    // 이름.
    private Rect nameRect = new Rect(0f, 0f, 120f, 24f);

    public GUIStyle nameLabelStyle;

    // 라이프바.
    public Texture backLifeBarTexture;

    public Texture frontLifeBarTexture;
    private float frontLifeBarOffsetX = 2f;
    private float lifeBarTextureWidth = 128f;
    private Rect playerLifeBarRect = new Rect(0f, 0f, 128f, 16f);
    private Color playerFrontLifeBarColor = Color.green;
    private Rect enemyLifeBarRect = new Rect(0f, 0f, 128f, 24f);
    private Color enemyFrontLifeBarColor = Color.red;

    // 플레이어 스테이터스 표시.
    private void DrawPlayerStatus()
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

    // 적 스테이터스 표시.
    private void DrawEnemyStatus()
    {
        if (playerStatus.lastAttackTarget != null)
        {
            CharacterStatus target_status = playerStatus.lastAttackTarget.GetComponent<CharacterStatus>();
            DrawCharacterStatus(
                (baseWidth - enemyLifeBarRect.width) / 2.0f, 0f,
                target_status,
                enemyLifeBarRect,
                enemyFrontLifeBarColor);
        }
    }

    // 캐릭터 스테이터스 표시.
    private void DrawCharacterStatus(float x, float y, CharacterStatus status, Rect bar_rect, Color front_color)
    {
        // 이름.
        GUI.Label(
            new Rect(x, y, nameRect.width, nameRect.height),
            status.characterName,
            nameLabelStyle);

        float life_value = (float)status.HP / status.MaxHP;
        if (backLifeBarTexture != null)
        {
            // 후면 라이브바.
            y += nameRect.height;
            GUI.DrawTexture(new Rect(x, y, bar_rect.width, bar_rect.height), backLifeBarTexture);
        }

        // 전면 라이프바.
        if (frontLifeBarTexture != null)
        {
            float resize_front_bar_offset_x = frontLifeBarOffsetX * bar_rect.width / lifeBarTextureWidth;
            float front_bar_width = bar_rect.width - resize_front_bar_offset_x * 2;
            var gui_color = GUI.color;
            GUI.color = front_color;
            GUI.DrawTexture(new Rect(x + resize_front_bar_offset_x, y, front_bar_width * life_value, bar_rect.height), frontLifeBarTexture);
            GUI.color = gui_color;
        }
    }

    private void OnGUI()
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