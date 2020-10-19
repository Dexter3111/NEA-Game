/*
 * Created Session - 3
 * Edited Session - 3
 * Purpose - This is used to show the score the player has during the game, I also used this to display the health.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CanvasNavigation : MonoBehaviour {

	private Canvas gameCanvas;

	// Use this for initialization
	//Keep the score canvas enabled throughout the game so the player can see their score and health.
	void Start () {
		gameCanvas = GameObject.FindObjectOfType<Canvas> ();
		gameCanvas.enabled = true ;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
