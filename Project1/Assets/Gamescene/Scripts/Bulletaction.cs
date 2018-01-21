using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletaction : MonoBehaviour {
	
	float bullettime = 0.8f;
	float time;
	void Start () {
		time = 0;
	}
	

	void Update () {
		time += Time.deltaTime;

		if (time > bullettime) {
			Destroy (this.gameObject);
		}
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Bullet") {
			Destroy (this.gameObject);
		}

		if (collision.gameObject.tag == "Wall") {
			Destroy (this.gameObject);
		}

	}
}
