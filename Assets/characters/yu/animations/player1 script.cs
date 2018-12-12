using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1script : MonoBehaviour {
    Animation anim; 
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("A"))
        {
            anim.Play("running");
        }
        else
        {
            anim.Play("idle");
        }
	}
}
