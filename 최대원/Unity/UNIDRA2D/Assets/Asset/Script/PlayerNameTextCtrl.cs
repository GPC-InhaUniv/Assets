using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameTextCtrl : MonoBehaviour {

    PlayerGeneratorCtrl playerGenerator;
    TextMesh textMesh;

    public Vector3 offset;
    // Use this for initialization
    void Start ()
    {
        playerGenerator = FindObjectOfType<PlayerGeneratorCtrl>();
        textMesh = GetComponent<TextMesh>();

        textMesh.text = playerGenerator.playerName;
        offset = new Vector3(0, 1f, 0);
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerGenerator.GetPlayerLife() >= 0)
        {
            transform.position = playerGenerator.playerPosition + offset;
        }
        else
            Destroy(gameObject);
    }
}
