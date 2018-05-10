using UnityEngine;

public class FireController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Unidra2DGameManager.Managerinstance.AddScore();

            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            Unidra2DGameManager.Managerinstance.Damaged();

            Destroy(gameObject);
        }
    }
}