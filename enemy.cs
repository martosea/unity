using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {
	NavMeshAgent nav;
	public Transform target;
	int score2;
	int hp = 0;
	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();

	}
	// Update is called once per frame
	void Update () {
		nav.SetDestination (target.position);
	}
	void OnCollisionEnter(Collision arg) {
		score2++;
		if (arg.gameObject.tag == "MainCamera" && score2 == 3) {
			Destroy (arg.gameObject);
		}
		if (arg.gameObject.tag == "bullet") {
			hp++;
			if (hp == 10) {
				Destroy (gameObject);
			}
		}
	}

}
