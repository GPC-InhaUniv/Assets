using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public enum ItemKind
    {
        Attack,
        Heal,
    }

    bool isPickedUp = false;

    public ItemKind kind;
    public AudioClip itemSeClip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
            aStatus.GetItem(kind);
            AudioSource.PlayClipAtPoint(itemSeClip, transform.position);

            PlayerCtrl playerCtrl = other.GetComponent<PlayerCtrl>();
            if (playerCtrl.GetComponent<NetworkView>().isMine)
            {
                GetItemOnNetwork(playerCtrl.GetComponent<NetworkView>().viewID);
            }
            else
            {
                GetComponent<NetworkView>().RPC("GetItemOnNetwork", GetComponent<NetworkView>().owner, playerCtrl.GetComponent<NetworkView>().viewID);
            }

        }
    }

    [RPC]
    void GetItemOnNetwork(NetworkViewID viewID)
    {
        if (isPickedUp) {
            return;
        }
        isPickedUp = true;
        NetworkView player = NetworkView.Find(viewID);
        if (player == null) {
            return;
        }
        if (player.isMine) {
            player.SendMessage("GetItem", kind);
        }
        else {
            player.GetComponent<NetworkView>().RPC("Getitem", player.owner, kind);
        }

        Network.Destroy(gameObject);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        if (GetComponent<NetworkView>().isMine)
        {
            Destroy(GetComponent<Rigidbody>());
        }
    }

    // Use this for initialization
    void Start ()
    {
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 6.0f;
        GetComponent<Rigidbody>().velocity = velocity;
    }

}
