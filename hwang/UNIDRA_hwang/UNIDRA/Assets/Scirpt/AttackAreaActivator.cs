using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreaActivator : MonoBehaviour {


    Collider[] attackAreaColliders;

    public AudioClip attackSeClip;
    AudioSource attackSeAudio;

    void Start () {

        
        AttackArea[] attackAreas = GetComponentsInChildren<AttackArea>();
        attackAreaColliders = new Collider[attackAreas.Length];


        Collider col;
        for (int attackAreaCnt = 0; attackAreaCnt < attackAreas.Length; attackAreaCnt++)
        {
            col = attackAreas[attackAreaCnt].GetComponent<Collider>();
            attackAreaColliders[attackAreaCnt] = col;
            attackAreaColliders[attackAreaCnt].enabled = false;
               

        }

        attackSeAudio = gameObject.AddComponent<AudioSource>();
        attackSeAudio.clip = attackSeClip;
        attackSeAudio.loop = false;

    }

    void StartAttackHit()
    {
        foreach (Collider attackAreaCollider in attackAreaColliders)
            attackAreaCollider.enabled = true;

        attackSeAudio.Play();
    }
    void EndAttackHit()
    {
        foreach (Collider attackAreaCollider in attackAreaColliders)
            attackAreaCollider.enabled = false;
    }


}
