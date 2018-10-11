using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

	// Use this for initialization
	public float speed;
	bool started;
	public bool gameOver;
	Rigidbody rb;
	public GameObject camera; 

	void Awake(){
		rb = GetComponent<Rigidbody>();
	}

	void Start () {
		// rb.velocity = new Vector3(speed,0,0);
		started = false;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!started){
			if(Input.GetMouseButtonDown(0)){
				rb.velocity = new Vector3(speed,0,0);
				started = true;
			}
		}
		if(!Physics.Raycast(transform.position,Vector3.down,1f)){
			gameOver= true;
			rb.velocity = new Vector3(0,-25f,0);
			camera.GetComponent<cameraFollow>().gameOver = true;
		}
		if(Input.GetMouseButtonDown(0) && !gameOver){
			switchDirection();
		}
	}

	void switchDirection(){
		if(rb.velocity.z > 0){
			rb.velocity = new Vector3(speed,0,0);
		}
		else if(rb.velocity.x >0){
			rb.velocity = new Vector3(0,0,speed);
		}
	}
}
