using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    enum PlayerState
    {
        move,
        damage,
    }

    public float moveStartDistance = 10f;
    public float moveForce = 150f;
    public float maxSpeed = 100f;
    float targetPointX;
    bool facingRight = true;
    Rigidbody2D rigidbody2D;
    PlayerState playerState;
    PlayerLifeCtrl playerLifeCtrl;
    public GameOver gameOverPrefeb;
    public ExplosionCtrl explosionCtrlPrefeb;

    private void Start()
    {
        Vector3 screen_point = Camera.main.WorldToScreenPoint(transform.position);
        targetPointX = screen_point.x;
        rigidbody2D = GetComponent<Rigidbody2D>();
        playerState = PlayerState.move;
        playerLifeCtrl = FindObjectOfType<PlayerLifeCtrl>();
    }

    private void Update()
    {
        if (playerState == PlayerState.move)
        {
            targetPointX = Input.GetAxis("Horizontal");
        }
    }

    private void FixedUpdate()
    {
        //좌표변환
        float horizontal = Mathf.Sign(targetPointX);

        if (playerState == PlayerState.move)
        {
            //이동
            if(targetPointX != 0)
            {
                rigidbody2D.AddForce(Vector2.right * horizontal * moveForce);
            }
            
            //방향조정
            if ((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
            {
                facingRight = !facingRight;
                Vector3 local_scale = transform.localScale;
                local_scale.x *= -1;
                transform.localScale = local_scale;
            }
        }

        //최대 속도 제한
        if (Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
        {
            rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Fire")
        {
            Animator myAnimator = GetComponent<Animator>();
            myAnimator.SetTrigger("Damage");
            if(playerLifeCtrl.PlayerLifeNum > 0)
            {
                Invoke("endDamage", 0.75f);
                playerState = PlayerState.damage;
                playerLifeCtrl.PlayerLifeNum--;

                //피격 시 날리기
                rigidbody2D.AddForce((Vector2.up * moveForce * 4) + (Vector2.left * moveForce * 5));
                //rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * moveForce / 10 * -1, (moveForce / 10));
            }
            else
            {
                playerState = PlayerState.damage;
                Instantiate(gameOverPrefeb);

                explosionCtrlPrefeb.transform.position = gameObject.transform.position;
                Instantiate(explosionCtrlPrefeb);
                Destroy(gameObject);
            }
        }
    }

    void endDamage()
    {
        targetPointX = gameObject.transform.position.x;
        playerState = PlayerState.move;
    }
}
