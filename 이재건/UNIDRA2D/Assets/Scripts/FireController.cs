using UnityEngine;

public class FireController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
            return;

        Destroy(gameObject);
    }
}