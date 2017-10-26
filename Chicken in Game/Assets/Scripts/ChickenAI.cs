using UnityEngine;
using System.Collections;


public class ChickenAI : MonoBehaviour {
	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;

	public Transform chickenPen;

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
	
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
									//forward//
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			/*Destroy(gomaObgject); */
			// scoreManager.AddPoint(points);
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
	}
}