using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReptileController : MonoBehaviour {
    Vector3 vPosition;
    CharacterStatus status;
    // Use this for initialization
    void Start () {
        vPosition = transform.position;
        status = GetComponent<CharacterStatus>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= 0.5)
        {
            vPosition = transform.position;
            transform.position = new Vector3(vPosition.x, --vPosition.y,vPosition.z);
         }
	}

    void Died()
    {
        status.died = true;
        AudioSource.PlayClipAtPoint(null, transform.position);
        Invoke("DelayedDestroy", 8.0f);  // ８초 후에 폐기.
    }

    void DelayedDestroy()
    {
        Network.Destroy(gameObject);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }


}
