using UnityEngine;

public class CharaAnimation : MonoBehaviour
{
    private Animator animator;
    private CharacterStatus status;
    private Vector3 prePosition;
    private bool isDown = false;
    private bool attacked = false;

    public bool IsAttacked()
    {
        return attacked;
    }

    private void StartAttackHit()
    {
        Debug.Log("StartAttackHit");
    }

    private void EndAttackHit()
    {
        Debug.Log("EndAttackHit");
        attacked = true;
    }

    private void EndAttack()
    {
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        status = GetComponent<CharacterStatus>();

        prePosition = transform.position;
    }

    private void Update()
    {
        Vector3 delta_position = transform.position - prePosition;
        animator.SetFloat("Speed", delta_position.magnitude / Time.deltaTime);

        if (attacked && !status.attacking)
        {
            attacked = false;
        }
        animator.SetBool("Attacking", (!attacked && status.attacking));

        if (!isDown && status.died)
        {
            isDown = true;
            animator.SetTrigger("Down");
        }

        prePosition = transform.position;
    }
}