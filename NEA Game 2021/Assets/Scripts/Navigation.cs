/*
 * Created Session - 1
 * Edited Session - 4
 * Purpose - used to load the different canvas' on the screen on the main menu, allowing for the player to pick different options
             also allows the player to change scene throughout the menu and within the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {

	private Canvas mainCanvas;
	private Canvas difficultCanvas;

	//Start Button
	public void ClickedButtonStart(){
		Debug.Log ("Start Game Button Clicked");
		mainCanvas.enabled = false;
		//difficultCanvas.enabled = true;

	}
	//Tutorial Button
	public void ClickedButtonTutorial(){
		//Debug.Log ("Tutorial button clicked");
		SceneManager.LoadScene (1);
	}
	//Controls Button
	public void ClickedButtonControls(){
		//Debug.Log("Controls Button Clicked");
		SceneManager.LoadScene(3);
	}
	//Main Menu Button
	public void ClickedButtonMenu(){
		//Debug.Log("Main Menu Button Clicked");
		SceneManager.LoadScene(0);
	}

	// Use this for initialization
	void Start () {
		mainCanvas = Canvas. ("Canvas") ;
		mainCanvas.enabled = true ;
		//difficultCanvas = GameObject.FindObjectOfType <Canvas> ();
		//difficultCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}


	}
}
