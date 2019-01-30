using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openWindow : MonoBehaviour {
    Animator animator;
    private bool first = true;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) //when smth enters the Collider
    {
        if (first)
        {
            animator.SetTrigger("openWin");
        }
        
    }
    private void OnTriggerExit(Collider other)//when smth exits the collider//https://www.youtube.com/watch?v=tUbNIwn1Htc
    {
        animator.enabled = true;
        first = false;
    }

    void Animationstop()
    {
        animator.enabled = false;
    }
}
