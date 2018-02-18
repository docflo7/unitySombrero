﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour {

    private Animator animator;

    void Start () {
        animator = GetComponentInParent<Animator>();
    }

    void OnTriggerEnter (Collider col) {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        if ((state.IsName("Patrol") || state.IsName("idle")) && col.gameObject.tag == "Player")
        {
            animator.SetTrigger("Pursuit");
        }
        //if (state.IsName("Pursuit") && target)
        //{
        //    animator.SetBool("IsPursuing", false);
        //}
    }
}
