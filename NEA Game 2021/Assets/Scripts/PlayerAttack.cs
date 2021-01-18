/*
 * Created Session - 8
 * Edited Session - 13
 * Purpose - How the player shoots.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject bullet;
	public GameObject player;

	// Update is called once per frame
	public void Update () {

		if (Input.GetKeyDown (KeyCode.Q)) 	{
			//Debug.Log ("shot");
			Debug.Log (Input.mousePosition.x);
			Debug.Log (Input.mousePosition.y);
			Debug.Log (Camera.main.ScreenToWorldPoint(Input.mousePosition)); 

			Vector2 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Instantiate (bullet, new Vector3(mousepos.x, mousepos.y, 0f), Quaternion.identity);

		
		}
	
	}
}
