using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCtrl : MonoBehaviour
{

    static int maxItemCount = 1;
    public static int currentItemCount = 0;
    public GameObject ItemPrefab;
    public GameObject ThunderPrefab;

    static public bool IsGetItem = false;
    public AudioClip MobilityClip;
    AudioSource mobilityAudio;
    public Animator myAnimator;
    public Camera camera;
    public Vector3 cameraPosition;
    // Use this for initialization
    void Start()
    {
        mobilityAudio = gameObject.AddComponent<AudioSource>();
        mobilityAudio.clip = MobilityClip;
        mobilityAudio.loop = false;
        mobilityAudio.volume = 1.0f;
        cameraPosition = camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsGetItem)
        {
            myAnimator.SetTrigger("Damage");
            mobilityAudio.Play();
            StartCoroutine(Shake());
            IsGetItem = false;
        }

        if (currentItemCount < maxItemCount&&Random.Range(0.0f,100.0f)>99.0f)
        {
            Instantiate(ItemPrefab, transform.position+new Vector3(Random.Range(-3,3),0,0), Quaternion.identity);
            currentItemCount++;
        }
    }

    IEnumerator Shake()
    {
        bool shake = false;
        int count = 0;
        while(true)
        {
            if (!shake)
            {
                camera.transform.position = new Vector3(cameraPosition.x+0.05f, cameraPosition.y + 0.05f, -10);
                shake = true;
            }
            else
            {
                shake = false;
                camera.transform.position = new Vector3(cameraPosition.x -0.05f, cameraPosition.y-0.05f, -10);
            }
            count++;
            if (count > 7)
                yield break;
            Instantiate(ThunderPrefab, transform.position + new Vector3(Random.Range(-3, 3), 0, 0), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
        }
    }

  
}
