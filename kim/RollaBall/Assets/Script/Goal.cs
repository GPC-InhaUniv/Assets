using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Goal : MonoBehaviour {
    public float overTime;
    public Text Textbox;
    public bool Endgame;
	// Use this for initialization
	void Start () {
        overTime = 0;
        Endgame = false;
	}
	
	// Update is called once per frame
	

    
    void Update()
    {
        if (Endgame == true)
        {
            Endgamefun();
        }
    }

    private void Endgamefun()
    {
        overTime += Time.deltaTime;       
          
            if (overTime > 3.0f)
                SceneManager.LoadScene("First Page");
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player"))
        {

            Textbox.text = "You Win";
            Endgame = true;

        }
    }
}
