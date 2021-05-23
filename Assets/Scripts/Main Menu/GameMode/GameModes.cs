using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModes : MonoBehaviour
{
    Animator animator;

    static public bool playGameModeAnimation = false;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (playGameModeAnimation)
        {
            //play animation
            animator.SetBool("playGameModeAnimation", true);
        }
    }
}
