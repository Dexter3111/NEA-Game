/*
 * Created Session - 1
 * Edited Session - 6
 * Purpose - used to load the different canvas' on the screen on the main menu, allowing for the player to pick different options
             also allows the player to change scene throughout the menu and within the game.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {

	private Canvas mainCanvas;
	private GameObject main;
	private GameObject difficult;
	private GameObject controls;

	//Start Button
	public void ClickedButtonStart(){
		//Setting the main menu false so the new difficulty menu shows instead.
		main.SetActive(false);
		difficult.SetActive(true);
		controls.SetActive (false);
		//Debug.Log ("Start Game Button Clicked");

	}
	//Tutorial Button
	public void ClickedButtonTutorial(){
		//Debug.Log ("Tutorial button clicked");
		SceneManager.LoadScene (1);
	}
	//Controls Button
	public void ClickedButtonControls(){
		//Debug.Log("Controls Button Clicked");
		main.SetActive(false);
		difficult.SetActive (false);
		controls.SetActive (true);
	}
	//Main Menu Button
	public void ClickedButtonMenu(){
		//Debug.Log("Main Menu Button Clicked");
		SceneManager.LoadScene(0);
	}
	//Easy
	public void ClickedButtonEasy(){
		SceneManager.LoadScene (2);
	}
	//Medium
	public void ClickedButtonMedium(){
		SceneManager.LoadScene (5);
	}
	//Hard
	public void ClickedButtonHard(){
		SceneManager.LoadScene (6);
	}

	// Use this for initialization
	void Start () {
		mainCanvas = GameObject.FindObjectOfType <Canvas> ();
		mainCanvas.enabled = true ;

		main = GameObject.FindGameObjectWithTag ("main");
		main.SetActive(true);

		difficult = GameObject.FindGameObjectWithTag ("difficult");
		difficult.SetActive(false);

		controls = GameObject.FindGameObjectWithTag ("controls");
		controls.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}


	}
}
