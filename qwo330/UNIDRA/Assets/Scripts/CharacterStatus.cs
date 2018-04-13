using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour {

    public int HP = 100;
    public int MaxHP = 100;
    public int Power = 10;

    public bool powerBoost = false;
    float powerBoostTime = 0.0f;

    public GameObject lastAttackTarget = null;

    public string characterName = "Player";

    public bool attacking = false;
    public bool died = false;

    public void GetItem(DropItem.ItemKind itemKind)
    {
        switch(itemKind)
        {
            case DropItem.ItemKind.Attack:
                powerBoostTime = 5.0f;
                break;
            case DropItem.ItemKind.Heal:
                HP = Mathf.Min(HP + MaxHP / 2, MaxHP);
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
