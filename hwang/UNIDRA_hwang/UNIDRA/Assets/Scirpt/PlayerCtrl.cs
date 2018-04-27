using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

    const float rayCastMaxDistance = 100.0f;
    InputManager inputManager;
    CharacterStatus status;
    CharaAnimation charaAnimation;
    Transform attackTarget;
    GameRuleCtrl gameRuleCtrl;
    TargetCursor targetCursor;
    public GameObject hitEffect;
    public AudioClip deathSeClip;
    AudioSource deathSeAudio;

    public float attackRange = 1.5f;
    public NetworkView nView;

    enum State
    {
        Walking,
        Attacking,
        Died,
    };
    State state = State.Walking;
    State nextState = State.Walking;


    void Start()
    {
        status = GetComponent<CharacterStatus>();
        charaAnimation = GetComponent<CharaAnimation>();
        inputManager = FindObjectOfType<InputManager>();
        gameRuleCtrl = FindObjectOfType<GameRuleCtrl>();
        targetCursor = FindObjectOfType<TargetCursor>();
        targetCursor.SetPosition(transform.position);

        deathSeAudio = gameObject.AddComponent<AudioSource>();
        deathSeAudio.loop = false;
        deathSeAudio.clip = deathSeClip;

        
        //NetworkView myNetView = FindObjectOfType<NetworkView>();
        //nView = myNetView;

    }
    private void Update()
    {

        if (!nView.isMine)
            return;

        switch (state)
        {
            case State.Walking:
                Walking();
                break;
            case State.Attacking:
                Attacking();
                break;
                
                
        }
        if(state != nextState)
        {
            state = nextState;
            switch (state)
            {
                case State.Walking:
                    WalkStart();
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
        if (inputManager.Clicked())
        {
            Ray ray = Camera.main.ScreenPointToRay(inputManager.GetCursorPosition());
            RaycastHit hitInfo;

            if(Physics.Raycast(ray,out hitInfo, rayCastMaxDistance, (1 << LayerMask.NameToLayer("Ground")) | (1<<LayerMask.NameToLayer("EnemyHit"))))
            {
                if (hitInfo.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
                {
                    SendMessage("SetDestination", hitInfo.point);
                    targetCursor.SetPosition(hitInfo.point);
                }
                if(hitInfo.collider.gameObject.layer == LayerMask.NameToLayer("EnemyHit"))
                {
                    Vector3 hitPoint = hitInfo.point;
                    hitPoint.y = transform.position.y;
                    float distance = Vector3.Distance(hitPoint, transform.position);
                    if (distance < attackRange)
                    {
                        attackTarget = hitInfo.collider.transform;
                        targetCursor.SetPosition(attackTarget.position);
                        ChangeState(State.Attacking);
                    }
                    else
                    {
                        SendMessage("SetDestination", hitInfo.point);
                        targetCursor.SetPosition(hitInfo.point);
                    }
                }
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
        if (charaAnimation.IsAttacked())
            ChangeState(State.Walking);
    }
    void Died()
    {
        status.died = true;
        deathSeAudio.Play();
        gameRuleCtrl.GameOver();
        Invoke("DelayedDestroy", 8.0f);  // 8초 후에 폐기.

    }

    void DelayedDestroy()
    {
        Network.Destroy(gameObject);
        Network.RemoveRPCs(nView.viewID);
    }
    void Damage(AttackArea.AttackInfo attackInfo)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity) as GameObject;
        effect.transform.localPosition = transform.position + new Vector3(0.0f, 0.5f, 0.0f);
        Destroy(effect, 0.3f);      
        if (nView.isMine)
            DamageMine(attackInfo.attackPower);
        else
            nView.RPC("DamageMine", nView.owner, attackInfo.attackPower); 
    }
    [RPC]
    void DamageMine(int damage)
    {
        status.Hp -= damage;
        if (status.Hp <= 0)
        {
            status.Hp = 0;
            // 체력이 0이므로 사망 스테이트로 전환한다.
            ChangeState(State.Died);
        }
    }

    void StateStartCommon()
    {
        status.attacking = false;
        status.died = false;
    }

    void OnNetworkInstantiate(NetworkMessageInfo info)
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
