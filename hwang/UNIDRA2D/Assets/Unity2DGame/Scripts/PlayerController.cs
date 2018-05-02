using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float moveStartDistance = 10.0f;
    public float moveForce = 150f;
    public float maxSpeed = 100f;
    float targetPointX;
    bool facingRight = true;

    [SerializeField]
    Rigidbody2D rb2D;

    void Start()
    {
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        targetPointX = screenPoint.x;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;
        targetPointX = Input.mousePosition.x;

    }

    void FixedUpdate()
    {
        if (Unidra2DGameManager.Managerinstance.NowGamestate == 0)
        {
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            if (Mathf.Abs(targetPointX - screenPoint.x) <= moveStartDistance)
                return;

            float horizontal = Mathf.Sign(targetPointX - screenPoint.x);
            rb2D.AddForce(Vector2.right * horizontal * moveForce);

            if (Mathf.Abs(rb2D.velocity.x) > maxSpeed)
                rb2D.velocity = new Vector2(Mathf.Sign(rb2D.velocity.x) * maxSpeed, rb2D.velocity.y);

            if (horizontal > 0 && !facingRight || (horizontal < 0 && facingRight))
            {
                facingRight = !facingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1;
                transform.localScale = localScale;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Fire")
        {
            Animator myAnimator = GetComponent<Animator>();
            myAnimator.SetTrigger("Damage");
        }
    }

}