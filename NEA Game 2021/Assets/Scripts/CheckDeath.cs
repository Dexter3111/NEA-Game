using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckDeath : MonoBehaviour {

	public int health;
	public TextMeshProUGUI healthText;

	// Use this for initialization
	void Start () {
		health = 100;
	}

	void OnCollisionEnter2D(Collision2D collision){

		if (collision.gameObject.tag == "heart") {
			//Debug.Log ("add 25 health");
			health += 25;
			healthText.text = "Health: " + health.ToString ();

		}
	
	}



	// Update is called once per frame
	void Update () {

		//Check if health == 0
		if (health == 0) {
			SceneManager.LoadScene (5);
		}




	}
}
