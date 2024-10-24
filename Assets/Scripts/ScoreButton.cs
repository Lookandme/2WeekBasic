using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public Animator _animator;
    public int _score = 0;
    public Action<int> OnScoreChanged;

    private void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }
    public void PointUp()
    {
       
        _score += 1;
        OnScoreChanged?.Invoke(_score);

    }
   
}
