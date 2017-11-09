using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wonder : MonoBehaviour {

public float moveSpeed;

void MoveFoward () {
	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);

}

void Turn() {
	int randomNum = Random.Range(0,360);
	transform.Rotate(0,randomNum,0);

}

void OnTriggerStay(Collider other){
	if(other.gameObject.tag == "CheckPoint"){
		Turn();

	}
	else{
		MoveFoward();
	}
}

}
