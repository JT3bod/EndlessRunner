using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartingScript : MonoBehaviour {
    public Button start;
    public Button quit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartButton_Clicked()
    {
        SceneManager.LoadScene("Level1");

    }
    public void QuitButton_Clicked()
    {
        Application.Quit();
    }
}
