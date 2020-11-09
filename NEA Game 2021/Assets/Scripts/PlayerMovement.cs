/*
 * Created Session - 2 
 * Edited Session - 7
 * Purpose - Players movement script. This scipt is used to get the players input and move the sprite across the level.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rb;
		
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.freezeRotation = true;
	}
	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.tag == "vase") {
			Debug.Log ("Vase");
			Destroy (collision.gameObject);
		}
	
	}

	
	// Update is called once per frame
	void Update () {

		//Player Movement = Forward
		if (Input.GetKey (KeyCode.W)) {
			rb.AddForce (new Vector2 (0, 1), ForceMode2D.Impulse);
			//Debug.Log("W pressed");
		}
		//Player Movement = Downwards
		if (Input.GetKey(KeyCode.S)){
			rb.AddForce (new Vector2(0, -1), ForceMode2D.Impulse);
			//Debug.Log("S pressed");
		}
		//Player Movement = Right
		if (Input.GetKey(KeyCode.D)){
			rb.AddForce(new Vector2 (1, 0), ForceMode2D.Impulse);
			//Debug.Log("D pressed");
		}
		//Player Movement = Left
		if (Input.GetKey(KeyCode.A)){
			rb.AddForce(new Vector2 (-1, 0), ForceMode2D.Impulse);
			//Debug.Log("A pressed");
		}

	}
}