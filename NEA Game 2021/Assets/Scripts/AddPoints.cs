/*
 * Created Session - 2 
 * Edited Session - 3
 * Purpose - All collectibles which add score / remove score will be present in this script.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AddPoints : MonoBehaviour {

	public int score;
	public TextMeshProUGUI scoreText;

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
			score += 1;
			scoreText.text = "Coins Collected: " + score.ToString();
		}

		//heart collectible
		if (collision.gameObject.tag == "heart") {
			//Debug.Log ("Heart");
			Destroy (collision.gameObject);


			//code it so it gives full health when picked up
		}

		//chest collectible
		if (collision.gameObject.tag == "chest") {
			//Debug.Log ("chest");

			//if all coins collected then proceed to win. If not all 10 collected then player cannot win yet.
			if (score == 10){
				SceneManager.LoadScene(4);
				Destroy (collision.gameObject);
				//Debug.Log ("WIN");
			}
		
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
