using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffusingFireCtrl : MonoBehaviour {
    public GameObject DiffusingFirePrefab;
    public float remainTime = 0.05f;
    public float interval = 0.3f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Fire") return;

        if (collision.gameObject.tag == "Field" || collision.gameObject.tag == "Player")
        {
            for (float i = -4f; i <= 4f; i += interval)
            {
                Instantiate(DiffusingFirePrefab, new Vector3(transform.position.x + i, transform.position.y, transform.position.z), Quaternion.identity);
            }
        }
        Destroy(gameObject, remainTime);
    }
}
