using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMoveWithObject : MonoBehaviour {
    public Transform target;
    public GameObject playerPanel;
    public float UIOffset = 16.63f;

	// Use this for initialization
	void Start () {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerPanel = GameObject.FindWithTag("PlayerHP");
        Debug.Log(Screen.height);
        UIOffset = Screen.height * UIOffset / 100;
    }

    // Update is called once per frame
    void FixedUpdate () {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(target.position);
        float x = screenPos.x + 0.3f;
        playerPanel.transform.position = new Vector3(x, screenPos.y + UIOffset, playerPanel.transform.position.z);
    }
}
