//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class guitraining : MonoBehaviour {

//    readonly int buttonCount = 4;
//    readonly float blank = 2.5f;

//    private void OnGUI()
//    {
//        for (int i = 0; i < buttonCount; i++)
//        {
//            GUI.Button(new Rect(GetX(blank * (2*i+1) + 40 * i), GetY(10), GetWidth(40), GetHeight(20)), "button");
//        }

//    }

//    private float GetX(float percent)
//    {
//        return Screen.width * percent / 100;
//        //return blank + Screen.width / buttonCount * num;
//    }
//    private float GetY(float percent)
//    {
//        return Screen.width * percent / 100;
//        //return blank + Screen.height / buttonCount * num;
//    }
//    private float GetWidth(float percent)
//    {
//        if (percent > 100 || percent < 1) return -1;
//        if (Screen.width * percent / 100 > Screen.width) return -1;
//        return Screen.width * percent / 100;
//    }
//    private float GetHeight(float percent)
//    {
//        if (percent > 100 || percent < 1) return -1;
//        return Screen.height * percent / 100;
//    }
//}
