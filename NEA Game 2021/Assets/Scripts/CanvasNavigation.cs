using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CanvasNavigation : MonoBehaviour {

	private Canvas scoreCanvas;

	// Use this for initialization
	void Start () {
		scoreCanvas = GameObject.FindObjectOfType<Canvas> ();
		scoreCanvas.enabled = true ;
	}
	
	// Update is called once per frame
	void Update () {

	}
}
