using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    TextMeshProUGUI scoreTxt;
  

    private void Awake()
    {

        scoreTxt = GetComponent<TextMeshProUGUI>();
        
        scoreButton.OnScoreChanged += RefreshUi;
    }

    public void RefreshUi(int newScore)
    {
        
        scoreTxt.text = $"Push Score : {scoreButton._score.ToString()}";
    }
}
