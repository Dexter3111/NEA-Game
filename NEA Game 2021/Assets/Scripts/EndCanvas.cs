/*
 * Created Session - 9
 * Edited Session - 9
 * Purpose - End canvas for winning and losing scenes.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCanvas : MonoBehaviour {

	public void ClickedButtonMenu(){
		//Debug.Log("Main Menu Button Clicked");
		SceneManager.LoadScene(0);
	}

	public void ClickedButtonTutorial(){
		SceneManager.LoadScene (1);
	}





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
