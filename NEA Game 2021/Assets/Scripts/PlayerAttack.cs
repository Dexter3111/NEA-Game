/*
 * Created Session - 8
 * Edited Session - 9
 * Purpose - How the player shoots.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject bullet;

	void SpawnBullet() {

		Vector3 mousepos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//Instantiate (bullet, new Vector2(0, 0), Quaternion.identity);
		Instantiate (bullet, new Vector3 (mousepos.x,mousepos.y,0), transform.rotation);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Q)) 	{
			Debug.Log ("shot");

			Debug.Log (Input.mousePosition.x);
			Debug.Log (Input.mousePosition.y);
			Debug.Log (Camera.main.ScreenToWorldPoint(Input.mousePosition)); 
			SpawnBullet ();
		
		
		}
	
	
	}
}
