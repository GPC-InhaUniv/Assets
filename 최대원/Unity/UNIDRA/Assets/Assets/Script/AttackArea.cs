
using UnityEngine;
using System.Collections;

public class AttackArea : MonoBehaviour
{
    CharacterStatus status;
    public AudioClip hitSeClip;
    AudioSource hitSeAudio;

    void Start()
    {
        status = transform.root.GetComponent <CharacterStatus> ();

        hitSeAudio = gameObject.AddComponent<AudioSource>();
        hitSeAudio.clip = hitSeClip;
        hitSeAudio.loop = false;
    }

    public class AttackInfo
    {
        public int attackPower;
        public Transform attacker;

    }

    AttackInfo GetAttackInfo()
    {
        AttackInfo attackInfo = new AttackInfo();

        //공격력 계산
        attackInfo.attackPower = status.Power;
        //공격력 강화
        if (status.powerBoost) attackInfo.attackPower += attackInfo.attackPower;

        attackInfo.attacker = transform.root;

        return attackInfo;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        other.SendMessage("Damage", GetAttackInfo());
        status.lastAttackTarget = other.transform.root.gameObject;
        hitSeAudio.Play();
    }

    void OnAttack()
    {
        GetComponent<Collider>().enabled = true;
    }

    void OnAttackTermination()
    {
        GetComponent<Collider>().enabled = false;
    }
}
