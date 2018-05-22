using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerCtrl : MonoBehaviour
{
    const float RayCastMaxDistance = 100.0f;
    CharacterStatus status;
    CharaAnimation charaAnimation;
    Transform attackTarget;
    InputManager inputManager;
    public float attackRange = 1.5f;
    GameRuleCtrl gameRuleCtrl;
    public GameObject hitEffect;
    TargetCursor targetCursor;
    Transform playerTransform;
    public AudioClip deadthSeClip;
    AudioSource deathSeAudio;
    public float playerMoveSpeed;
    CharacterController characterController;
    FollowCamera followCamera;
    float rotationSpeed = 360.0f;
    Vector3 velocity = Vector3.zero;
    const float GravityPower = 9.8f;
    Vector3 playerLookRotation;
    Vector3 cameraLookRotation;
    Rigidbody rigidbody;

    // 스테이트 종류.
    enum State
    {
        Walking,
        Attacking,
        Died,
    };

    State state = State.Walking;        // 현재 스테이트.
    State nextState = State.Walking;    // 다음 스테이트.


    // Use this for initialization
    void Start()
    {
        status = GetComponent<CharacterStatus>();
        charaAnimation = GetComponent<CharaAnimation>();
        inputManager = FindObjectOfType<InputManager>();
        gameRuleCtrl = FindObjectOfType<GameRuleCtrl>();
        targetCursor = FindObjectOfType<TargetCursor>();
        targetCursor.SetPosiotion(transform.position);
        playerTransform = GetComponent<Transform>();
        characterController = GetComponent<CharacterController>();
        followCamera = FindObjectOfType<FollowCamera>();
        rigidbody = GetComponent<Rigidbody>();


        deathSeAudio = gameObject.AddComponent<AudioSource>();
        deathSeAudio.loop = false;
        deathSeAudio.clip = deadthSeClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<NetworkView>().isMine) return;

        switch (state)
        {
            case State.Walking:
                Walking();
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
                case State.Attacking:
                    AttackStart();
                    break;
                case State.Died:
                    Died();
                    break;
            }
        }

        //중력
        velocity += Vector3.down * GravityPower * Time.deltaTime;
        // 땅에 닿아 있다면 지면을 꽉 누른다.
        // (유니티의 CharactorController 특성 때문에).
        Vector3 snapGround = Vector3.zero;
        if (characterController.isGrounded)
        {
            snapGround = Vector3.down;
        }
        characterController.Move(velocity * Time.deltaTime + snapGround);
    }


    // 스테이트를 변경한다.
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
            ChangeState(State.Attacking);
        }
        else
        {
            playerMove();
        }
    }

    // 공격 스테이트가 시작되기 전에 호출된다.
    void AttackStart()
    {
        StateStartCommon();
        status.attacking = true;
    }

    // 공격 중 처리.
    void Attacking()
    {
        if (charaAnimation.IsAttacked())
            ChangeState(State.Walking);
    }

    void Died()
    {
        status.died = true;
        //gameRuleCtrl.gameOver = true;
        deathSeAudio.Play();
        Invoke("DelayedDestroy", 8.0f);
    }

    void DelayedDestroy()
    {
        Network.Destroy(gameObject);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    void Damage(AttackArea.AttackInfo attackInfo)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity) as GameObject;
        effect.transform.localPosition = transform.position + new Vector3(0f, 0.5f, 0f);
        Destroy(effect, 0.3f);

        if (GetComponent<NetworkView>().isMine)
        {
            RpcDamageMine(attackInfo.attackPower);
        }
        else
        {
            GetComponent<NetworkView>().RPC("RpcDamageMine", GetComponent<NetworkView>().owner, attackInfo.attackPower);
        }
    }

    [RPC]
    void RpcDamageMine(int Damage)
    {
        status.HP -= Damage;
        if(status.HP <= 0)
        {
            status.HP = 0;
            ChangeState(State.Died);
        }
    }

    // 스테이트가 시작되기 전에 스테이터스를 초기화한다.
    void StateStartCommon()
    {
        status.attacking = false;
        status.died = false;
    }

    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        if (!GetComponent<NetworkView>().isMine)
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

    private void playerMove()
    {
        playerLookRotation = inputManager.GetPlayerDiretion();
        cameraLookRotation = new Vector3(0, followCamera.transform.rotation.y,0);

        transform.localRotation = Quaternion.LookRotation(cameraLookRotation);
        characterController.Move(playerLookRotation * playerMoveSpeed * Time.deltaTime);
    }
}
