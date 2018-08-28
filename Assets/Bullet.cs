using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private Rigidbody bullet;
	public float speedBullet;

	void Awake()
	{
		bullet = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () 
	{
		bullet.velocity = new Vector3 (speedBullet, bullet.velocity.y, bullet.velocity.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
