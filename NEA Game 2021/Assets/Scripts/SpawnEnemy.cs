/*
 * Created Session - 7
 * Edited Session - 12
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
	public int count;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnE", 5.0f, 1.0f);
		count = 0;
	}

	//the method to allow enemies to instantiate/spawn at 0, 0 on the level.
	void SpawnE(){
		Instantiate (enemy, new Vector2(0, 0), Quaternion.identity);
		count = count + 1;
		//Debug.Log ("enemy spawned");
	}
	
	// Update is called once per frame
	//Set a limit to the amount of enemies spawned in total
	void Update () {

		if (count == 5){
				
				CancelInvoke();

			}


		}
	
	}
