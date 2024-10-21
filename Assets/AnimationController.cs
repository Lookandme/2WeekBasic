using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        

        _animator.SetInteger("ChageAnimation", animationVariable);

        animationVariable = (animationVariable + 1) % 3;
         
    }
}
