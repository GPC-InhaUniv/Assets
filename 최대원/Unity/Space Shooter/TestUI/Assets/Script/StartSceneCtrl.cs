using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneCtrl : MonoBehaviour
{
    public GameObject HelpPanel;
    public GameObject RankingPanel;

    private void Start()
    {
        HelpPanel.SetActive(false);
        RankingPanel.SetActive(false);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OnHelpClick()
    {
        HelpPanel.SetActive(true);
    }
    public void OnRankingClick()
    {
        RankingPanel.SetActive(true);
    }

    public void ClosePopup()
    {
        HelpPanel.SetActive(false);
        RankingPanel.SetActive(false);
    }
}
