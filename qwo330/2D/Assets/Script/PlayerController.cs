using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveStartDistance = 10f;
    public float moveForce = 150f;
    public float maxSpeed = 100f;
    public float jumpForce = 800.0f;
    public float Life;

    const float MaxLife = 10;
    float targetPointX;
    bool facingRight = true;
    bool canJump = true;

    new Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start () {
        Vector3 screen_point = Camera.main.WorldToScreenPoint(transform.position);
        targetPointX = screen_point.x;
        rigidbody2D = GetComponent<Rigidbody2D>();
        Life = MaxLife;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) // 왼쪽
            targetPointX = Input.mousePosition.x;
        else if (Input.GetMouseButtonDown(1) && canJump) // 오른쪽
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce);
            canJump = false;
        }
    }

    private void FixedUpdate()
    {
        Vector3 screen_point = Camera.main.WorldToScreenPoint(transform.position);

        if (Mathf.Abs(targetPointX - screen_point.x) <= moveStartDistance)
            return;

        // 방향 계산
        float horizontal = Mathf.Sign(targetPointX - screen_point.x);
        rigidbody2D.AddForce(Vector2.right * horizontal * moveForce);

        // 이동속도 제한
        if (Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
            rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);

        // 방향 조정
        if((horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight))
        {
            facingRight = !facingRight;
            Vector3 local_scale = transform.localScale;
            local_scale.x *= -1;
            transform.localScale = local_scale;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Fire")
        {
            if (Life > 0) Life--;
            Animator myAnimator = GetComponent<Animator>();
            myAnimator.SetTrigger("Damage");
        }

        if (collision.gameObject.tag == "Field")
            canJump = true;
    }

    public float GetPlayerMaxLife() { return MaxLife; }
}
