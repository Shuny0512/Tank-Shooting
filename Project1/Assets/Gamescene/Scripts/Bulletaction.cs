using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletaction : MonoBehaviour {


	void Start () {
		Shoot (new Vector3 (0, 0, -200));
	}
	

	void Update () {
		
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Bullet") {
			Destroy (this.gameObject);
		}
	
	}
		
	void Shoot (Vector3 dir) {
		GetComponent<Rigidbody> ().AddForce (dir);
	}
		
}
