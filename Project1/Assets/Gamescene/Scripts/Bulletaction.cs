using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletaction : MonoBehaviour {
	

	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Bullet") {
			Destroy (this.gameObject);
		}

		if (collision.gameObject.tag == "Player") {
			Destroy (gameObject);
	
		}

	}
}
