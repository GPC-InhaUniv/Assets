using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ani : MonoBehaviour {

    public ScrollRect scrollRect;

    public void changeValue()
    {
        Debug.Log("velocity : " + scrollRect.velocity);
        Debug.Log("horizontalNormalizedPosition : " + scrollRect.horizontalNormalizedPosition);

        if(scrollRect.horizontalNormalizedPosition < 0.1f)
        {
            scrollRect.horizontalNormalizedPosition = 0f;
        }
        if (scrollRect.horizontalNormalizedPosition > 0.9f)
        {
            scrollRect.horizontalNormalizedPosition = 1f;
        }
        if (scrollRect.horizontalNormalizedPosition < 0.6f && scrollRect.horizontalNormalizedPosition > 0.4f)
        {
            scrollRect.horizontalNormalizedPosition = 0.5f;
        }

    }
       
}
