using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject bullet;
	public GameObject pause;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	//	if (pause == false) {

		if (Input.GetKeyDown (KeyCode.Q)) 	{
				Debug.Log ("shot");
				Ray view = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (view))
					Instantiate (bullet, transform.position, transform.rotation);
				}
		
		//}
	
	
	}
}
