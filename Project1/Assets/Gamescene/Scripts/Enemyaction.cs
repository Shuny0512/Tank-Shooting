using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyaction : MonoBehaviour {
	
	Rigidbody rb;
	float enemyspeed = 5;

	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	

	void FixedUpdate () {
		
		rb.velocity = new Vector3 (rb.velocity.x, rb.velocity.y, transform.localScale.z * enemyspeed);
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Bullet") {
			Destroy (gameObject);

		}

		if (collision.gameObject.tag == "Wall") {
			Vector3 temp = gameObject.transform.localScale;
			temp.z *= -1;

			gameObject.transform.localScale = temp;
		}
	}


	}





