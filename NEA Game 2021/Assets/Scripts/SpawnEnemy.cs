/*
 * Created Session - 7
 * Edited Session - 10
 * Purpose - This is used to locate spawning areas and spawn enemies inside of that area 
 if the raycast hits the area.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {


	//use ray cast to some how identify the tile map
	// then use that tile map to spawn in enemies

	public GameObject enemy;
	private bool spawned = false;


	// Use this for initialization
	void Start () {
		
	}

	//the method to allow enemies to instantiate/spawn at 0, 0 on the level.
	void SpawnE(){
		Instantiate (enemy, new Vector2(0, 0), Quaternion.identity);
		spawned = true;
		Debug.Log ("enemy spawned");
	}
	
	// Update is called once per frame
	//Every 5 seconds more enemies should spawn.
	void Update () {

		if (spawned == false) {
			Invoke ("SpawnE", 5);
		}
	
	}
}
