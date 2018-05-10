using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public float HP = 100;
    float MaxHP = 100;
    public Texture LifeBarTexture;
    Color playerFrontLifeBarColor = Color.green;
    public AudioClip HeartClip;
    AudioSource heartAudio;

    public AudioClip DeathClip;
    AudioSource deathAudio;

    public float HpPosX;
    public float HpPosY;
    

    // Use this for initialization
    private void Start()
    {
        heartAudio = gameObject.AddComponent<AudioSource>();
        heartAudio.clip = HeartClip;
        heartAudio.loop = false;
        heartAudio.volume = 0.3f;
        deathAudio = gameObject.AddComponent<AudioSource>();
        deathAudio.clip = DeathClip;
        deathAudio.loop = false;
        deathAudio.volume = 1.0f;

        if (Screen.fullScreen)
            HpPosX = Screen.width - 100;
        else
            HpPosX = Screen.width - 100;

        HpPosY = 0;
    }
    void OnGUI()
    {

        var gui_color = GUI.color;
        GUI.color =playerFrontLifeBarColor;
        GUI.DrawTexture(new Rect(HpPosX, HpPosY, HP , MaxHP/5 ), LifeBarTexture);
        GUI.color = gui_color;
       
     
    }

    public void Damage()
    {
        if (HP > 0)
        {
            heartAudio.Play();
            HP -= 20;
        }
        if (HP <= 0&&transform.position.z>=-10)
        {
          
            Debug.Log("GameOver");
            deathAudio.Play();
            this.transform.position = new Vector3(0, 0, -20);
        }
    }

 
}
