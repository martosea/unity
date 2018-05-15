using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision arg) {
		
		if (arg.gameObject.tag == "wall") {
			Destroy (gameObject);
		}
	}
}
