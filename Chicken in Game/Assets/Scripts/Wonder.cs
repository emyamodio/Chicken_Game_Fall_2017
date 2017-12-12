using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : MonoBehaviour {

public float moveSpeed;

public Transform[] waypoints;

public int currentPoint;

void Start(){
	Turn();

}
void MoveFoward () {
	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);

}

void Turn() {
	currentPoint = Random.Range(0,11);
	transform.LookAt(waypoints[currentPoint]);
	Debug.Log(currentPoint);
}

void OnTriggerEnter(Collider other){

	Turn();
}

void Update(){
		// Debug.Log(moveSpeed);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		transform.LookAt(waypoints[currentPoint]);
	}
}
