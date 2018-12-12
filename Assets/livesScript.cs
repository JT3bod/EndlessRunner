using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class livesScript : MonoBehaviour {
    public Text lives;
    public GameObject yu;
    public GameObject en;

    int Lives;
	// Use this for initialization
	void Start () {
        Lives = 3;
        lives.text = ("Lives: " + Lives);
	}
	
	// Update is called once per frame
	void Update () {
        float pos1 = (yu.transform.position.x);
        float pos2 = (en.transform.position.x);
        float total = pos1 - pos2;
        if (total == -1)
        {
            Lives -= 1;
            lives.text = ("Lives: " + Lives);
        }
        if (Lives == -1) 
            {
                lives.text = ("Game Over!");
            } 
	}
}
