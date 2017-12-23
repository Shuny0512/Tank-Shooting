using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody rigid;
	float movespeed = 3.0f;
	public GameObject BulletPrefab;
	float bulletspeed = 10f;


	void Start () {
		
		
		
	}
	

	void Update () {

		if (Input.GetKeyUp ("space")) {
			GameObject bullet = Instantiate (BulletPrefab) as GameObject;


			bullet.GetComponent<Rigidbody> ().velocity = transform.forward * bulletspeed;
			bullet.transform.position = transform.position;

		}

		if (Input.GetButton ("Horizontal") || Input.GetButton ("Vertical")) {
			transform.Translate (Vector3.forward * Time.deltaTime * movespeed * 1); //まっすぐ歩く
		}

		if (Input.GetButton ("Horizontal") || Input.GetButton ("Vertical")) {
			transform.rotation = Quaternion.LookRotation (transform.position + (Vector3.right * Input.GetAxisRaw ("Horizontal")) + (Vector3.forward * Input.GetAxisRaw ("Vertical")) - transform.position);
		}
	}

	void OnCollisionEnter (Collision collsion) {
		if (collsion.gameObject.tag == "Enemy") {
			Destroy (this.gameObject);
		}
	}
}
