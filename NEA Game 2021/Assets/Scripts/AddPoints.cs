using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddPoints : MonoBehaviour {

	public int score;
	public TextMeshPro scoreText;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	//Collectibles
	void OnCollisionEnter2D(Collision2D collision){

		//Coin collectible
		if (collision.gameObject.tag == "coin") {
			//Debug.Log ("Coin");
			Destroy (collision.gameObject);
			score += 5;
			scoreText.text = "Score: " + score.ToString();
		}

		if (collision.gameObject.tag == "hearts") {
			Debug.Log ("Heart");
			Destroy (collision.gameObject);

			//code it so it gives full health when picked up
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
