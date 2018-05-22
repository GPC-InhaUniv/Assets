using System.Collections;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public NetworkView networkView;

    public enum ItemKind
    {
        Attack,
        Heal,
    }

    public ItemKind kind;

    public AudioClip itemSeClip;

    private bool isPickedUp = false;

    private void OnTriggerEnter(Collider other)
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
            if (playerCtrl.networkView.isMine)
            {
                if (networkView.isMine)
                    GetItemOnNetwork(playerCtrl.networkView.viewID);
                else
                    networkView.RPC("GetItemOnNetwork", networkView.owner, playerCtrl.networkView.viewID);
            }
        }
    }

    [RPC]
    // 아이템 획득 처리.
    public void GetItemOnNetwork(NetworkViewID viewId)
    {
        if (gameObject.tag != "butter")
        {
            // 픽업 플래그.
            if (isPickedUp)
                return;
            isPickedUp = true;

            // 픽업한 Player를 찾는다.
            NetworkView player = NetworkView.Find(viewId);
            if (player == null)
                return;

            // 픽업한 플레이어에게 아이템을 준다.
            if (player.isMine)
                player.SendMessage("GetItem", kind);
            else
                player.GetComponent<NetworkView>().RPC("GetItem", player.owner, kind);

            Network.Destroy(gameObject);
            Network.RemoveRPCs(networkView.viewID);
        }
    }

    private void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        if (!networkView.isMine)
            Destroy(GetComponent<Rigidbody>());
    }

    private void Start()
    {
        networkView = GetComponent<NetworkView>();
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        GetComponent<Rigidbody>().velocity = velocity;
    }

    private void Update()
    {
    }
}