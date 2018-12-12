using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseScript : MonoBehaviour {
    public Animator anim;
    public Slider sliderInstance;

    bool broken = false;
    // Use this for initialization
    void Start () {
        anim.Play("house");
	}
	
	// Update is called once per frame
	void Update () {
        if (broken)
        {
            anim.Play("houseBroken");
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (sliderInstance.value == 100)
            {
                anim.Play("house broken");
                broken = true;
            }
        }
	}
}
