using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	// Use this for initialization
	public GameObject ball;
	Vector3 offset;
	public float lerpRate;
	public bool gameOver;

	void Start () {
		offset = ball.transform.position - transform.position;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!gameOver){
			follow();
		}
	}

	void follow(){
		Vector3 pos = transform.position;
		Vector3 targetpos = ball.transform.position -offset;
		pos = Vector3.Lerp(pos,targetpos,lerpRate*Time.deltaTime);
		transform.position = pos;
	}
}
