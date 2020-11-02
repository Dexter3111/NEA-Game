/*
 * Created Session - 3
 * Edited Session - 6
 * Purpose - This is used to show the score the player has during the game, I also used this to display the health.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNavigation : MonoBehaviour {

	private Canvas gameCanvas;
	private GameObject score;
	private GameObject pause;

	// Use this for initialization
	//Keep the score canvas enabled throughout the game so the player can see their score and health.
	void Start () {
		gameCanvas = GameObject.FindObjectOfType<Canvas> ();
		gameCanvas.enabled = true ;

		score = GameObject.FindGameObjectWithTag ("score");
		score.SetActive(true);

		pause = GameObject.FindGameObjectWithTag ("pause");
		pause.SetActive (false);
	}

	public void ClickedButtonResume(){
		pause.SetActive (false);
	}

	public void ClickedButtonTutorial(){
		SceneManager.LoadScene (1);
	}

	public void ClickedButtonMenu(){
		SceneManager.LoadScene (0);
	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Escape)){
			pause.SetActive (true);
		}

	}
}
