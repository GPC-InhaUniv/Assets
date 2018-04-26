using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour
{	
	public int HP = 100;
	public int MaxHP = 100;
	public int Power = 10;
	public GameObject lastAttackTarget = null;

    public string characterName = "Player";

	public bool attacking = false;
	public bool died = false;

    public bool powerBoost = false;
    float powerBoostTime = 0.0f;
    ParticleSystem powerUpEffect;
    
    [RPC]
    public void SetName(string name)
    {
        characterName = name;
    }

    [RPC]
    public void GetItem(DropItem.ItemKind itemKind)
    {
        switch (itemKind)
        {
            case DropItem.ItemKind.Attack:
                powerBoostTime = 30.0f;
                powerUpEffect.Play();
                break;
            case DropItem.ItemKind.Heal:
                HP = Mathf.Min(HP + 30, MaxHP);
                break;
        }
    }

    private void Update()
    {
        if (gameObject.tag != "Player") return;

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

    private void Start()
    {
        if(gameObject.tag == "Player")
        {
            powerUpEffect = transform.Find("PowerUpEffect").GetComponent<ParticleSystem>();
        }
    }
}
