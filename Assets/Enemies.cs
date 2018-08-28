using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour {

	public Rigidbody Enemie;
	public float speedEnemy;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Enemie.velocity = new Vector3 (-speedEnemy, Enemie.velocity.y, Enemie.velocity.z);
	}
}
