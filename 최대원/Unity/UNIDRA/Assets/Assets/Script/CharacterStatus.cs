using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour
{	
	// 체력.
	public int HP = 100;
	public int MaxHP = 100;
	
	// 공격력.
	public int Power = 10;
	
	// 마지막에 공격한 대상.
	public GameObject lastAttackTarget = null;

	// 플레이어 이름.
	public string characterName = "Player";

	// 상태.
	public bool attacking = false;
	public bool died = false;

    //공격력 강화
    public bool powerBoost = false;
    //공격력 강화 시간
    float powerBoostTime = 0.0f;
    
    public void GetItem(DropItem.ItemKind itemKind)
    {
        switch (itemKind)
        {
            case DropItem.ItemKind.Attack:
                powerBoostTime = 30.0f;
                break;
            case DropItem.ItemKind.Heal:
                HP = Mathf.Min(HP + 30, MaxHP);
                break;
        }
    }

    private void Update()
    {
        powerBoost = false;
        if(powerBoostTime > 0.0f)
        {
            powerBoost = true;
            powerBoostTime = Mathf.Max(powerBoostTime - Time.deltaTime, 0.0f);
        }
    }
}
