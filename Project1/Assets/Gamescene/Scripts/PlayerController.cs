using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody rigid;
	float movespeed = 3.0f;
	public Transform playerpos;
	public GameObject BulletPrefab;



	void Start () {
		
		
		
	}
	

	void Update () {
		if (Input.GetKey ("up")) {
			transform.position += transform.forward * movespeed * Time.deltaTime;
		}
		if (Input.GetKey ("down")) {
			transform.position -= transform.forward * movespeed * Time.deltaTime;
		}
		if (Input.GetKey ("right")) {
			transform.position += transform.right * movespeed * Time.deltaTime;
		}
		if (Input.GetKey ("left")) {
			transform.position -= transform.right * movespeed * Time.deltaTime;
		}

		if (Input.GetKeyUp ("space")) {
			GameObject bullet = Instantiate (BulletPrefab) as GameObject;
			bullet.transform.position = playerpos.position;


		}


	}

	void OnCollisionEnter (Collision collsion) {
		if (collsion.gameObject.tag == "Enemy") {
			Destroy (this.gameObject);
		}
	}
}
