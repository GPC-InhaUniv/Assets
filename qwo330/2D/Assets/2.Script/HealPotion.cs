using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("플레이어 충돌");
            for (int i = 0; i < gameManager.Slots.Length; i++)
            {
                if (gameManager.SlotFull[i] == 0) // 0이면 null 
                {
                    gameManager.Slots[i].sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                    gameManager.SlotFull[i] = (int)GameManager.ItemList.HealPotion;
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}