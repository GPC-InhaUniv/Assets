using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldControll : MonoBehaviour
{
    Text text;
    public int gold;
    int goldMax;

	void Start ()
    {
        text = GetComponent<Text>();
        gold = 0;
        goldMax = 999999;
    }
	
	void Update ()
    {
        gold += 3141;
        if (gold > goldMax)
        {
            text.text = "+" + goldMax.ToString("N0");
        }
        else
        {
            text.text = gold.ToString("N0");
        }        
    }
}
