using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour {
    CharacterStatus status;
    CharaAnimation charaAnimation;
    CharacterMove characterMove;
    Transform attackTarget;
    GameRuleCtrl gameRuleCtrl;

    public float waitBaseTime = 2.0f;
    float waitTime;
    public float walkRange = 5.0f;
    public Vector3 basePosition;

    public GameObject[] dropItemPrefabs = new GameObject[2];
    public GameObject hitEffect;

    enum State
    {
        Walking,
        Chasing,
        Attacking,
        Died,
    }

    State state = State.Walking;
    State nextState = State.Walking;

    public AudioClip deathSeClip;
    public AudioClip attackSeClip;
    new NetworkView networkView;

    // Use this for initialization
    void Start() {
        status = GetComponent<CharacterStatus>();
        charaAnimation = GetComponent<CharaAnimation>();
        characterMove = GetComponent<CharacterMove>();
        gameRuleCtrl = FindObjectOfType<GameRuleCtrl>();

        basePosition = transform.position;
        waitTime = waitBaseTime;
    }

    // Update is called once per frame
    void Update() {
        if (!networkView.isMine)
            return;

        switch (state)
        {
            case State.Walking: Walking(); break;
            case State.Chasing: Chasing(); break;
            case State.Attacking: Attacking(); break;
        }

        if (state != nextState)
        {
            state = nextState;
            switch (state)
            {
                case State.Walking: WalkStart(); break;
                case State.Chasing: ChaseStart(); break;
                case State.Attacking: AttackStart(); break;
                case State.Died: Died(); break;
            }
        }
    }

    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        networkView = GetComponent<NetworkView>();
        if (!networkView.isMine)
        {
            CharacterMove move = GetComponent<CharacterMove>();
            Destroy(move);

            AttackArea[] attackAreas = GetComponentsInChildren<AttackArea>();
            foreach (AttackArea attackArea in attackAreas)
            {
                Destroy(attackArea);
            }

            AttackAreaActivator attackAreaActivator = GetComponent<AttackAreaActivator>();
            Destroy(attackAreaActivator);
        }
    }

    public void SetAttackTarget(Transform target)
    {
        attackTarget = target;
    }

    void StateStartCommon()
    {
        status.attacking = false;
        status.died = false;
    }

    void ChangeState(State nextState)
    {
        this.nextState = nextState;
    }

    void WalkStart()
    {
        StateStartCommon();
    }
    void Walking()
    {
        if (waitTime > 0.0f)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0.0f)
            {
                Vector2 randomValue = Random.insideUnitCircle * walkRange;
                Vector3 destinationPosition = basePosition + new Vector3(randomValue.x, 0.0f, randomValue.y);
                SendMessage("SetDestination", destinationPosition);
            }
        }
        else
        {
            if (characterMove.Arrived())
            {
                waitTime = Random.Range(waitBaseTime, waitBaseTime * 2.0f);
            }
            if (attackTarget)
            {
                ChangeState(State.Chasing);
            }
        }
    }

    void ChaseStart()
    {
        StateStartCommon();
    }
    void Chasing()
    {
        SendMessage("SetDestination", attackTarget.position);
        if (Vector3.Distance(attackTarget.position, transform.position) <= 2.0f)
        {
            ChangeState(State.Attacking);
        }
    }

    void AttackStart()
    {
        StateStartCommon();
        status.attacking = true;

        // 적이 있는 방향으로 돌아본다.
        Vector3 targetDirection = (attackTarget.position - transform.position).normalized;
        SendMessage("SetDirection", targetDirection);

        // 이동을 멈춘다.
        SendMessage("StopMove");
        AudioSource.PlayClipAtPoint(attackSeClip, transform.position);
    }
    void Attacking()
    {
        if (charaAnimation.IsAttacked())
        {
            ChangeState(State.Walking);
            waitTime = Random.Range(waitBaseTime, waitBaseTime * 2.0f);
            attackTarget = null;
        }
    }

    void DropItem()
    {
        if (dropItemPrefabs.Length == 0)
            return;
        GameObject dropItem = dropItemPrefabs[Random.Range(0, dropItemPrefabs.Length)];
        Network.Instantiate(dropItem, transform.position, transform.rotation, 0);
    }

    void Died()
    {
        status.died = true;
        DropItem();
        AudioSource.PlayClipAtPoint(deathSeClip, transform.position);

        if (gameObject.tag == "Boss")
            gameRuleCtrl.GameClear();

        Network.Destroy(gameObject);
        Network.RemoveRPCs(networkView.viewID);
    }

void Damage(AttackArea.AttackInfo attackInfo)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity) as GameObject;
        effect.transform.localPosition = transform.position + new Vector3(0.0f, 0.5f, 0.0f);
        Destroy(effect, 0.3f);

        if (networkView.isMine)
            DamageMine(attackInfo.attackPower);
        else
            networkView.RPC("DamageMine", networkView.owner, attackInfo.attackPower);
    }

    [RPC]
    void DamageMine(int damage)
    {
        status.HP -= damage;
        if(status.HP <= 0)
        {
            status.HP = 0;
            ChangeState(State.Died);
        }
    }
}
