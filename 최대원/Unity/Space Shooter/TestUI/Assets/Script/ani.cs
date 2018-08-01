using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ani : MonoBehaviour {

    public ScrollRect scrollRect;
    public int SelectPlayerIndex;

    public Image image;
    public Sprite spriteRed;
    public Sprite spriteOrange;
    public Sprite spriteGreen;

    private void Start()
    {
        changeText(SelectPlayerIndex);
    }

    public void changeText(int index)
    {
        switch (index)
        {
            case 0:
                image.sprite = spriteRed;
                break;
            case 1:
                image.sprite = spriteOrange;
                break;
            case 2:
                image.sprite = spriteGreen;
                break;

            default:
                break;
        }
    }

    public void Update()
    {
        if(scrollRect.horizontalNormalizedPosition < 0.33f)
        {
            SelectPlayerIndex = 0;
            if (0f < scrollRect.horizontalNormalizedPosition && scrollRect.horizontalNormalizedPosition < 0.05f)
            {
                scrollRect.horizontalNormalizedPosition = 0f;
            }
        }

        if (0.34f < scrollRect.horizontalNormalizedPosition && scrollRect.horizontalNormalizedPosition < 0.66f)
        {
            SelectPlayerIndex = 1;
            if (scrollRect.horizontalNormalizedPosition < 0.55f && scrollRect.horizontalNormalizedPosition > 0.45f)
            {
                scrollRect.horizontalNormalizedPosition = 0.5f;
            }
        }

        if (0.67f < scrollRect.horizontalNormalizedPosition)
        {
            SelectPlayerIndex = 2;
            if (0.95f < scrollRect.horizontalNormalizedPosition && scrollRect.horizontalNormalizedPosition < 1f)
            {
                scrollRect.horizontalNormalizedPosition = 1f;
            }
        }

        changeText(SelectPlayerIndex);
    }
       
}
