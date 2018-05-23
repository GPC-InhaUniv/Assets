using UnityEngine;
using System.Collections;

public class DropItem : MonoBehaviour
{
    public enum ItemKind
    {
        Attack,
        Heal,
    };
    public ItemKind kind;
    bool isPickedUp = false;      //픽업 플래그
    public AudioClip itemSeClip;
    NetworkView networkView;

    void OnTriggerEnter(Collider other)
    {
        // Player인지 판정.
        if (other.tag == "Player")
        {
            // 아이템 획득.
            CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
            aStatus.GetItem(kind);
            // 오디오 재생. 
            AudioSource.PlayClipAtPoint(itemSeClip, transform.position);
            // 아이템 획득을 소유자에게 알린다.
            PlayerCtrl playerCtrl = other.GetComponent<PlayerCtrl>();
            if(playerCtrl.networkView.isMine)
            {
                if (networkView.isMine)
                    GetItemOnNetwork(playerCtrl.networkView.viewID);
                else
                    networkView.RPC("GetItemOnNetwork", networkView.owner, playerCtrl.networkView.viewID);
            }
        }
    }

    [RPC]
    //아이템 획득처리
    void GetItemOnNetwork(NetworkViewID viewid)
    {
        //픽업 플래그
        if (isPickedUp)
            return;
        isPickedUp = true;
        //획득한 Player를 찾는다.
        NetworkView player = NetworkView.Find(viewid);
        if (player == null)
            return;

        //획득한 Player에게 아이템을 준다.
        if (player.isMine)
            player.SendMessage("GetItem", kind);
        else
            player.GetComponent<NetworkView>().RPC("GetItem", player.owner, kind);

        Network.Destroy(gameObject);
        Network.RemoveRPCs(networkView.viewID);
    }

    void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        if (!networkView.isMine)
            Destroy(GetComponent<Rigidbody>());
    }

    // Use this for initialization
    void Start()
    {
        networkView = GetComponent<NetworkView>();
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        GetComponent<Rigidbody>().velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
