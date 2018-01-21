using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapgenerator : MonoBehaviour {

	public GameObject StagePrefab;
	public GameObject WallPrefab;
	public GameObject PlayerPrefab;
	public GameObject StonewallPrefab;
	public GameObject EnemyPrefab;

	int position;

	void Start () {
		for (int x = -1; x <= 9; x++) {
			for (int y = -1; y <= 9; y++) {
				
		GameObject stage = Instantiate (StagePrefab) as GameObject;
				stage.transform.position = new Vector3 (x, 0, y);

	}
		}

		GameObject wall = Instantiate (WallPrefab) as GameObject;
		wall.transform.position = new Vector3 (1, 1, 1);

		GameObject player = Instantiate (PlayerPrefab) as GameObject;
		player.transform.position = new Vector3 (4, 1, 4);

		GameObject stonewall = Instantiate (StonewallPrefab) as GameObject;
		stonewall.transform.position = new Vector3 (-0.5f, 0.5f, -0.8f);

		GameObject enemy1 = Instantiate (EnemyPrefab) as GameObject;
		enemy1.transform.position = new Vector3 (3, 1, 0);

		GameObject enemy2 = Instantiate (EnemyPrefab) as GameObject;
		enemy2.transform.position = new Vector3 (1, 1, 2);



	}

	void Update () {
		
	}
}
