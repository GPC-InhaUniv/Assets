using UnityEngine;
using System.Collections;
using System;

public class DropItem : MonoBehaviour {
	public enum ItemKind
	{
		Attack,
		Heal,
	};
	public ItemKind kind;

    public AudioClip itemSeClip;

    bool isPickedUp = false;
	
	void OnTriggerEnter(Collider other)
	{	
		// Player인지 판정. 
		if( other.tag == "Player" )
        {
			// 아이템 획득.
			CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
			aStatus.GetItem(kind);
            // 오디오 재생
            AudioSource.PlayClipAtPoint(itemSeClip, transform.position);
            // 아이템 획득을 소유자에게 알린다.
            PlayerCtrl playerCtrl = other.GetComponent<PlayerCtrl>();
            if (playerCtrl.GetComponent<NetworkView>().isMine)
            {
                if (GetComponent<NetworkView>().isMine)
                {
                    GetItemOnNetwork(playerCtrl.GetComponent<NetworkView>().viewID);
                }
                else
                    GetComponent<NetworkView>().RPC("GetItemOnNetwork", GetComponent<NetworkView>().owner, playerCtrl.GetComponent<NetworkView>().viewID);
            }
		}
	}

    [RPC]
    // 아이템 획득 처리
    void GetItemOnNetwork(NetworkViewID viewID)
    {
        // 픽업 플래그
        if (isPickedUp)
            return;
        isPickedUp = true;

        // 획득한 Player를 찾는다.
        NetworkView player = NetworkView.Find(viewID);
        if (player == null)
            return;

        // 획득한 Player에게 아이템을 준다.
        if (player.isMine)
            player.SendMessage("GetItem", kind);
        else
            player.GetComponent<NetworkView>().RPC("GetItem", player.owner, kind);

        Network.Destroy(gameObject);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        if (!GetComponent<NetworkView>().isMine)
            Destroy(GetComponent<Rigidbody>());
    }

    // Use this for initialization
    void Start () {
		Vector3 velocity = UnityEngine.Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
