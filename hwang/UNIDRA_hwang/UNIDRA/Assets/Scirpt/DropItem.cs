using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour {

    private Rigidbody rb;
    private NetworkView nView;
    bool isPickedUp = false;

    public enum ItemKind
    {
        Heal,

        Attack,
    };
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
            if (playerCtrl.nView.isMine)
            {
                if (nView.isMine)
                {
                    GetItemOnNetwork(playerCtrl.nView.viewID);
                    Debug.Log(playerCtrl.nView.viewID.ToString());
                }
                else
                {
                    nView.RPC("GetItemOnNetwork", nView.owner, playerCtrl.nView.viewID);
                }
            }
        }
    }


    // Use this for initialization
    void Start () {
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        rb = GetComponent<Rigidbody>();
        rb.velocity = velocity;


	}
    [RPC]
    void GetItemOnNetwork(NetworkViewID viewID)
    {
        if (isPickedUp)
            return;
        isPickedUp = true;

        NetworkView FindPlayer= NetworkView.Find(viewID);
        NetworkView myView = FindPlayer.GetComponent<NetworkView>();
        if (FindPlayer == null)
            return;
        if (FindPlayer.isMine)
            FindPlayer.SendMessage("GetItem", kind);
        else
            myView.RPC("GetItem", FindPlayer.owner, kind);

        Network.Destroy(gameObject);
        Network.RemoveRPCs(nView.viewID);
    }

    void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        NetworkView myNetView = GetComponent<NetworkView>();
        nView = myNetView;
        if (!nView.isMine)
            Destroy(rb);
    }
}
