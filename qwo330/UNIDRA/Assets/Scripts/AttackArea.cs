
using UnityEngine;
using System.Collections;

public class AttackArea : MonoBehaviour {

    CharacterStatus status;
    public new Collider collider;

    void Start()
    {
        collider = transform.GetComponent<Collider>();
        status = transform.root.GetComponent<CharacterStatus>();
    }

    public class AttackInfo
    {
        public int attackPower;
        public Transform attacker;
    }

    AttackInfo GetAttackInfo()
    {
        AttackInfo attackInfo = new AttackInfo();
        attackInfo.attackPower = status.Power;
        if (status.powerBoost)
            attackInfo.attackPower += attackInfo.attackPower;

        attackInfo.attacker = transform.root;

        return attackInfo;
    }

    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("Damage", GetAttackInfo());
        status.lastAttackTarget = other.transform.root.gameObject;
    }

    void OnAttack()
    {
        collider.enabled = true;
    }

    void OnAttackTermination()
    {
        collider.enabled = false;
    }
}
