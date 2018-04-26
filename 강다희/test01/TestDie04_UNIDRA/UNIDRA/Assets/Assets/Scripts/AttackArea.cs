using UnityEngine;
using System.Collections;

public class AttackArea : MonoBehaviour
{
    private CharacterStatus status;

    public AudioClip hitSeClip;
    private AudioSource hitSeAudio;

    private void Start()
    {
        status = transform.root.GetComponent<CharacterStatus>();

        hitSeAudio = gameObject.AddComponent<AudioSource>();
        hitSeAudio.clip = hitSeClip;
        hitSeAudio.loop = false;
    }

    public class AttackInfo
    {
        public int attackPower; // 이 공격의 공격력.
        public Transform attacker; // 공격자.
    }

    // 공격 정보를 가져온다.
    private AttackInfo GetAttackInfo()
    {
        AttackInfo attackInfo = new AttackInfo();
        // 공격력 계산.
        attackInfo.attackPower = status.Power;

        if (status.powerBoost) //공격 강화중.
            attackInfo.attackPower += attackInfo.attackPower;

        attackInfo.attacker = transform.root;

        return attackInfo;
    }

    // 맞았다.
    private void OnTriggerEnter(Collider other)
    {
        // 공격 당한 상대의 Damage 메시지를 보낸다.
        other.SendMessage("Damage", GetAttackInfo());

        status.lastAttackTarget = other.transform.root.gameObject;
        hitSeAudio.Play();
    }

    // 공격 판정을 유효로 한다.
    private void OnAttack()
    {
        GetComponent<Collider>().enabled = true;
    }

    // 공격 판정을 무효로 한다.
    private void OnAttackTermination()
    {
        GetComponent<Collider>().enabled = false;
    }
}