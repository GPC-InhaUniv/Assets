using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreaActivator : MonoBehaviour {

    Collider[] attackAreaColliders;
    public AudioClip attackSeClip;
    AudioSource attackSeAudio;

	// Use this for initialization
	void Start () {
        AttackArea[] attackAreas = GetComponentsInChildren<AttackArea>();
        attackAreaColliders = new Collider[attackAreas.Length];

        for (int attackAreaCnt = 0; attackAreaCnt < attackAreas.Length; attackAreaCnt++)
        {
            // AttackArea 스크립트가 추가된 오브젝트의 컬라이더를 배열에 저장한다.
            attackAreaColliders[attackAreaCnt] = attackAreas[attackAreaCnt].GetComponent<Collider>();
            attackAreaColliders[attackAreaCnt].enabled = false;
        }

        // 오디오 초기화
        attackSeAudio = gameObject.AddComponent<AudioSource>();
        attackSeAudio.clip = attackSeClip;
        attackSeAudio.loop = false;
	}
	
    // 애니메이션 이벤트의 StartAttackHit로 컬라이더를 유효로 한다.
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
