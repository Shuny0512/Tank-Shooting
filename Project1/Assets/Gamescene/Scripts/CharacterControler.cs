using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Translate (-3, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			transform.Translate (3, 0, 0); 
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.Translate (0, 0, -3);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Translate (0, 0, 3);
		}
	}
}
