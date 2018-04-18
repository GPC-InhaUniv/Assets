using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    const float RayCastMaxDistance = 100.0f;

    GameRuleCtrl gameRuleCtrl;
    InputManager inputManager;
    CharacterStatus status;
    CharaAnimation charaAnimation;
    Transform attackTarget;
    public float attackRange = 1.5f;

    public GameObject hitEffect;
    TargetCursor targetCursor;

    public AudioClip deathSeClip;
    AudioSource deathSeAudio;

    enum State
    {
        Walking,
        Attacking,
        Died,
    };

    State state = State.Walking;
    State nextState = State.Walking;

    // Use this for initialization
    void Start () {
        status = GetComponent<CharacterStatus>();
        charaAnimation = GetComponent<CharaAnimation>();
        inputManager = FindObjectOfType<InputManager>();
        //inputManager = FindObjectOfType(typeof(InputManager)) as InputManager;
        //GameObject obj = GameObject.FindGameObjectWithTag("TagName");
        gameRuleCtrl = FindObjectOfType<GameRuleCtrl>();

        targetCursor = FindObjectOfType<TargetCursor>();
        targetCursor.SetPosition(transform.position);

        deathSeAudio = gameObject.AddComponent<AudioSource>();
        deathSeAudio.loop = false;
        deathSeAudio.clip = deathSeClip;
	}
	
	// Update is called once per frame
	void Update () {
        switch(state)
        {
            case State.Walking:
                Walking(); break;
            case State.Attacking:
                Attacking(); break;
        }
        if(state != nextState)
        {
            state = nextState;
            switch(state)
            {
                case State.Walking:
                    WalkStart(); break;
                case State.Attacking:
                    AttackStart(); break;
                case State.Died:
                    Died(); break;
            }
        }
	}

    void ChangeState(State nextState)
    {
        this.nextState = nextState;
    }

    void Died()
    {
        status.died = true;
        gameRuleCtrl.GameOver();
        deathSeAudio.Play();
    }

    void Damage(AttackArea.AttackInfo attackInfo)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity) as GameObject;
        effect.transform.localPosition = transform.position + new Vector3(0.0f, 0.5f, 0.0f);
        Destroy(effect, 0.3f);

        status.HP -= attackInfo.attackPower;
        if(status.HP <= 0)
        {
            status.HP = 0;
            ChangeState(State.Died);
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

    void WalkStart()
    {
        StateStartCommon();
    }

    void Walking()
    {
        if(inputManager.Clicked())
        {
            Ray ray = Camera.main.ScreenPointToRay(inputManager.GetCursorPosition());
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, RayCastMaxDistance, 
                1 << LayerMask.NameToLayer("Ground") | 1 << LayerMask.NameToLayer("EnemyHit")))
            {
                if(hitInfo.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
                {
                    SendMessage("SetDestination", hitInfo.point);
                    targetCursor.SetPosition(hitInfo.point);
                }
                if (hitInfo.collider.gameObject.layer == LayerMask.NameToLayer("EnemyHit"))
                {
                    // 수평 거리를 체크해서 공격할지 결정한다.
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

    void StateStartCommon()
    {
        status.attacking = false;
        status.died = false;
    }
}
