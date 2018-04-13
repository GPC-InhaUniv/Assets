using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour {

    public enum ItemKind
    {
        Attack,
        Heal,
    };
    public ItemKind kind;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
            aStatus.GetItem(kind);
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = velocity;
	}
}
