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
    new Rigidbody rigidbody;
    public AudioClip itemSeClip;
    bool isPickedUp = false;
    new NetworkView networkView;
    

    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        networkView = GetComponent<NetworkView>();
        if (!networkView.isMine)
            Destroy(rigidbody);
    }

        private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
            aStatus.GetItem(kind);
            AudioSource.PlayClipAtPoint(itemSeClip, transform.position);
            PlayerCtrl playerCtrl = other.GetComponent<PlayerCtrl>();
            if (playerCtrl.networkView.isMine)
                GetItemOnNetwork(playerCtrl.networkView.viewID);
            else
                networkView.RPC("GetItemOnNetwork", networkView.owner, playerCtrl.networkView.viewID);
        }
    }

    [RPC]
    void GetItemOnNetwork(NetworkViewID viewId)
    {
        if (isPickedUp)
            return;
        isPickedUp = true;

        // 획득한 player를 찾는다.
        NetworkView player = NetworkView.Find(viewId);

        // 획득한 player에게 아이템을 준다.
        if (player.isMine)
            player.SendMessage("GetItem", kind);
        else
            player.RPC("GetItem", player.owner, kind);

        Network.Destroy(gameObject);
        Network.RemoveRPCs(networkView.viewID);
    }

    // Use this for initialization
    void Start () {
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = velocity;
        
	}
}
