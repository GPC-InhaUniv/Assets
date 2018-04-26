using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoCtrl : MonoBehaviour {

    CharacterStatus status;
    RhinoAnimator rhinoAnimator;
    CharacterMove characterMove;
    public Transform attackTarget;
    public GameRuleCtrl gameRuleCtrl;

    public GameObject hitEffect;

    public float waitBaseTime = 2.0f;

    float waitTime;

    public float walkRange = 5.0f;

    public Vector3 basePosition;

    public GameObject[] dropItemPrefab;

    public NetworkView nView;


    enum State
    {
        Walking,	// 탐색.
        Chasing,	// 추적.
        Attacking,	// 공격.
        Died,       // 사망.
        Damaged,
    };

    State state = State.Walking;
    State nextState = State.Walking;
    public AudioClip deathSeClip;


    void Start()
    {
        status = GetComponent<CharacterStatus>();
        rhinoAnimator = GetComponent<RhinoAnimator>();
        characterMove = GetComponent<CharacterMove>();
        gameRuleCtrl = FindObjectOfType<GameRuleCtrl>();

        basePosition = transform.position;
        waitTime = waitBaseTime;

    }
    // Update is called once per frame
    void Update()
    {

        if (!nView.isMine)
            return;

        switch (state)
        {
            case State.Walking:
                Walking();
                break;
            case State.Chasing:
                Chasing();
                break;
            case State.Attacking:
                Attacking();
                break;
        }
        if (state != nextState)
        {
            state = nextState;
            switch (state)
            {
                case State.Walking:
                    WalkStart();
                    break;
                case State.Chasing:
                    ChaseStart();
                    break;
                case State.Attacking:
                    AttackStart();
                    break;
                case State.Died:
                    Died();
                    break;
            }
        }
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
        // 이동할 곳을 플레이어에 설정한다.
        SendMessage("SetDestination", attackTarget.position);
        // 2미터 이내로 접근하면 공격한다.
        if (gameObject.tag == "Boss")
        {
            if (Vector3.Distance(attackTarget.position, transform.position) <= 6.0f)
            {
                ChangeState(State.Attacking);

            }

        }
        else
        {
            if (Vector3.Distance(attackTarget.position, transform.position) <= 2.0f)
            {
                ChangeState(State.Attacking);
            }
        }
    }

    void AttackStart()
    {
        StateStartCommon();
        status.attacking = true;

        Vector3 targetDirection = (attackTarget.position - transform.position).normalized;
        SendMessage("SetDirection", targetDirection);

        SendMessage("StopMove");
    }
    void Attacking()
    {
        if (rhinoAnimator.IsAttacked())
            ChangeState(State.Walking);

        waitTime = Random.Range(waitBaseTime, waitBaseTime * 2.0f);

        attackTarget = null;

    }
    void dropItem()
    {
        if (dropItemPrefab.Length == 0)
        {
            return;
        }
        GameObject dropItem = dropItemPrefab[Random.Range(0, dropItemPrefab.Length)];
        Network.Instantiate(dropItem, transform.position, Quaternion.identity, 0);


    }
    void Died()
    {
        status.died = true;
        dropItem();
        AudioSource.PlayClipAtPoint(deathSeClip, transform.position);
        if (gameObject.tag == "Boss")
        {
            gameRuleCtrl.GameClear();
        }


        StartCoroutine(DestroyObt());

    }

    IEnumerator DestroyObt()
    {

        yield return new WaitForSeconds(2.0f);
        Network.Destroy(gameObject);
        Network.RemoveRPCs(nView.viewID);
    }



    void Damage(AttackArea.AttackInfo attackInfo)
    {

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity) as GameObject;
        effect.transform.localPosition = transform.position + new Vector3(0.0f, 0.5f, 0.0f);
        Destroy(effect, 0.3f);


        if (nView.isMine)
        {
            DamageMine(attackInfo.attackPower);
        }
        else
        {

            nView.RPC("DamageMine", nView.owner, attackInfo.attackPower);
        }
    }
    [RPC]
    void DamageMine(int damage)
    {
        status.Hp -= damage;
                    status.Damaged = true;

        if (status.Hp <= 0)
        {
            status.Hp = 0;

            ChangeState(State.Died);
        }
    }

    void StateStartCommon()
    {
        status.attacking = false;
        status.died = false;
        status.Damaged = false;

    }

    public void SetAttackTarget(Transform target)
    {
        attackTarget = target;
    }
    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        NetworkView myNetView = GetComponent<NetworkView>();
        nView = myNetView;
        if (!nView.isMine)
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
}
