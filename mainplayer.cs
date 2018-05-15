using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainplayer : MonoBehaviour {
	Rigidbody rb;
	float v;
	float h;
	int score=0;
	Transform tr;
	Rigidbody clon;
	float f;
	public Rigidbody obj;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		tr = GetComponent<Transform> ();
		clon = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		v = Input.GetAxis ("Vertical");
		h = Input.GetAxis ("Horizontal");
		Vector3 force = new Vector3 (0,0,v);
		Vector3 power = new Vector3 (0, h, 0);
		rb.velocity = tr.forward * v * 5f;
		tr.Rotate (power * 12f);
		f = Input.GetAxis ("Fire1");
		if (f > 0.5) {
			clon = Instantiate (obj, tr.position, tr.rotation);
			clon.AddForce (tr.forward * 3000f);
		}
	}
	void OnCollisionEnter(Collision arg) {
		if (arg.gameObject.tag == "sphere") {
			Destroy (arg.gameObject);
			score++;
			Debug.Log (score);
		}
		if (arg.gameObject.tag == "cube" && score == 2) {
			Destroy (arg.gameObject);
		}

	}
}
