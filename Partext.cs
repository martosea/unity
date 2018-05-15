using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partext : MonoBehaviour {
	public TextMesh txt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision arg) {
		
		if (arg.gameObject.tag == "MainCamera") {
			Debug.Log ("nfidm");
			txt.text = "Ключ находится на красной ветке";
		}
	}
}
