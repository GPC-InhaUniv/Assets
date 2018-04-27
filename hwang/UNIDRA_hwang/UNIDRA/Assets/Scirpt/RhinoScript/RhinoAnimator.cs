using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoAnimator : MonoBehaviour {


    Animator animator;
    CharacterStatus status;
    Vector3 prePosition;
    bool isDown = false;
    bool attacked = false;
    bool isDamaged = false;

    public bool IsAttacked()
    {
        return attacked;
    }
    void StartAttackHit()
    {
        //Debug.Log("StartAttackHit");
    }
    void EndAttackHit()
    {
        //Debug.Log("EndAttackHit");
    }
    void EndAttack()
    {
        attacked = true;
    }
    void EndDamage()
    {
        isDamaged = true;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        status = GetComponent<CharacterStatus>();

        prePosition = transform.position;
    }

    private void Update()
    {
        Vector3 deltaPosition = transform.position - prePosition;
        animator.SetFloat("Speed", deltaPosition.magnitude / Time.deltaTime);

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
        if(isDamaged && !status.Damaged)
        {
            isDamaged = false;
            Debug.Log(!isDamaged && status.Damaged);
        }
        animator.SetBool("Damaged", (!isDamaged && status.Damaged));
    }

}
