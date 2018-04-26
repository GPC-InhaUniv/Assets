using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nameplate : MonoBehaviour {

    public Vector3 offset = new Vector3(-0.5f, 2.0f, 0);
    public CharacterStatus status;
    TextMesh textMesh;

	// Use this for initialization
	void Start () {
        textMesh = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
        if (textMesh.text != status.characterName)
            textMesh.text = status.characterName;
        // 머리 위로 이동
        transform.position = status.transform.position + offset;
        // 카메라와 같은 방향으로
        transform.rotation = Camera.main.transform.rotation;

        float scale = Camera.main.transform.InverseTransformPoint(transform.position).z / 30.0f;
        transform.localScale = Vector3.one * scale;
	}
}
