using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

[System.Serializable]
public class Boundary
{
	public float zMin, zMax;
}


public class PlayerShip : MonoBehaviour {


	public GameObject spaceShip;
	float movementSpeed = 100f;

	[Header("Shooting Properties")]
	public GameObject bullet;
	public Transform spawnBullet;
	private float nextBullet;


	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.UpArrow)) 
		{
			spaceShip.transform.Translate (Vector3.forward  * movementSpeed, Space.World);
		}

		if (Input.GetKeyDown(KeyCode.DownArrow)) 
		{
			spaceShip.transform.Translate (Vector3.back  * movementSpeed, Space.World);
		}

		if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextBullet) 
		{
			nextBullet = Time.time * 1.03f;
			Instantiate (bullet, spawnBullet.position, spawnBullet.rotation);
		}
	}
}
