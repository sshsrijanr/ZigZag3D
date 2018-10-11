using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour {
	public GameObject platform;
	public GameObject ball;
	Vector3 lastpos;
	float size;

	bool GameOver;
	// Use this for initialization
	void Start () {
		GameOver = false;
		lastpos = platform.transform.position;
		size = platform.transform.localScale.x;

	}
	int rand = Random.Range(0,6);

	// Update is called once per frame
	void Update () {
		rand = Random.Range(0,6);
		if(ball.GetComponent<ballController>().gameOver == true){
			GameOver = true;
		}
		if(!GameOver){
			if(rand < 3){
				SpawnX();
			}else{
				SpawnZ();
			}
		}
		
	}
	void SpawnX(){
		Vector3 pos = lastpos;
		pos.x += size;
		lastpos = pos;
		Instantiate(platform,pos,Quaternion.identity);
	}
	void SpawnZ(){
		Vector3 pos = lastpos;
		pos.z += size;
		lastpos = pos;
		Instantiate(platform,pos,Quaternion.identity);
	}
}
