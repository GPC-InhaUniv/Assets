using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour {


    public int Hp = 100;
    public int MaxHp = 100;

    public int Power = 10;

    //마지막에 공격한 대상//
    public GameObject lastAttackTarget = null;

    public string characterName = "Player";

    public bool attacking = false;
    public bool died = false;
    public bool Damaged = false;


    public bool powerBoost = false;

    float powerBoostTime = 0.0f;

    ParticleSystem powerUpEffect;
    [RPC]
    public void GetItem(DropItem.ItemKind itemKind)
    {
        switch (itemKind)
        {
            case DropItem.ItemKind.Attack:
                powerBoostTime = 5.0f;
                powerUpEffect.Play();
                break;
            case DropItem.ItemKind.Heal:
                Hp = Mathf.Min(Hp + MaxHp / 2, MaxHp);
                break;

        }
    }
    private void Start()
    {
        if (gameObject.tag == "Player")
        {
            powerUpEffect = transform.Find("PowerUpEffect").GetComponent<ParticleSystem>();
        }
    }

    private void Update()
    {
        if(gameObject.tag != "Player")
        {
            return;
        }

        powerBoost = false;
        if(powerBoostTime > 0.0f)
        {
            powerBoost = true;
            powerBoostTime = Mathf.Max(powerBoostTime - Time.deltaTime, 0.0f);
        }
        else
        {
            powerUpEffect.Stop();
        }
    }

    [RPC]
    public void SetName(string name)
    {
        characterName = name;
    }







}
