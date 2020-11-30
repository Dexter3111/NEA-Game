/*
 * Created Session - 8
 * Edited Session - 10
 * Purpose - How the player shoots.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject bullet;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Q)) 	{
			//Debug.Log ("shot");
			Debug.Log (Input.mousePosition.x);
			Debug.Log (Input.mousePosition.y);
			Debug.Log (Camera.main.ScreenToWorldPoint(Input.mousePosition)); 

			float mouseposX = Input.mousePosition.x;
			float mouseposY = Input.mousePosition.y;

			//Vector3 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//Instantiate (bullet, new Vector2(0, 0), Quaternion.identity);
			Instantiate (bullet, new Vector3 (mouseposX,mouseposY, 0f), transform.rotation);

		
		}
	
	}
}
