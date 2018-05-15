using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invoke : MonoBehaviour {
	Transform tr;
	public GameObject enemy;
	GameObject clone;
	public Transform target;
	// Use this for initialization
	void Start () {
		
		InvokeRepeating("enemyclass", 2.0f, 0.3f);
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void enemyclass() {
		clone = Instantiate (enemy,tr.position,tr.rotation);
		clone.GetComponent<UnityEngine.AI.NavMeshAgent> ().SetDestination (target.position);
	}
}
