using UnityEngine;
using System.Collections;

public class DropItem : MonoBehaviour {
    

    public AudioClip itemSeClip;

    bool isPickedUp = false;

    NetworkView networkview;

    public enum ItemKind
	{
		Attack,
		Heal,
	};
    
	public ItemKind kind;

    // Use this for initialization
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody = GetComponent<Rigidbody>();
        Vector3 velocity = Random.insideUnitSphere * 2.0f + Vector3.up * 8.0f;
        rigidbody.velocity = velocity;
        networkview = GetComponent<NetworkView>();
    }


    void OnTriggerEnter(Collider other)
	{	
		// Player인지 판정. 
		if( other.tag == "Player" ){
			// 아이템 획득.
			CharacterStatus aStatus = other.GetComponent<CharacterStatus>();
			aStatus.GetItem(kind);
			// 획득했으면 아이템을 삭제.
			//Destroy(gameObject);
            //오디오재생
            AudioSource.PlayClipAtPoint(itemSeClip, transform.position);

            PlayerCtrl playerCtrl = other.GetComponent<PlayerCtrl>();
            if (playerCtrl.GetComponent<NetworkView>().isMine)
            {
                if(networkview.isMine)
                {
                    GetItemOnNetwork(playerCtrl.GetComponent<NetworkView>().viewID);

                }
                else
                {
                    GetComponent<NetworkView>().RPC("GetItemOnNetwork", GetComponent<NetworkView>().owner, playerCtrl.GetComponent<NetworkView>().viewID);
                }
            }

            
        }
        
	}
    void GetItemOnNetwork(NetworkViewID viewID)
    {
        if (isPickedUp)
        {
            return;
        }
        isPickedUp = true;
        NetworkView player = NetworkView.Find(viewID);
        if (player == null)
        {
            return;
        }

        if (player.isMine)
        {
            player.SendMessage("GetItem", kind);
        }
        else
            player.GetComponent<NetworkView>().RPC("GetItem", player.owner, kind);

        Network.Destroy(gameObject);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        if (!(GetComponent<NetworkView>().isMine))
            Destroy(GetComponent<Rigidbody>());
    }

    // Update is called once per frame
    void Update () {
	
	}
}
