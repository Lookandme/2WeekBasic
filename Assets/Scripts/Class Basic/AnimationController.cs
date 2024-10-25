using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public ScoreButton scoreButton;
    private Animator _animator;
    private int animationVariable;
    

     private void Awake()
    {
        _animator = GetComponent<Animator>();
        scoreButton.OnScoreChanged += ChangeAnimation;
    }

    public void ChangeAnimation(int changeAniNum)
    {
        
        _animator.SetInteger("ChageAnimation", animationVariable);

        animationVariable = (animationVariable + 1) % 3;
    }








}
