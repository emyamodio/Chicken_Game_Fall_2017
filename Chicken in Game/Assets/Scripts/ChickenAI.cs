using UnityEngine;
using System.Collections;


public class ChickenAI : MonoBehaviour {
	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	public int points = 100;

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
			ScoreManager.AddPoints(points);
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;


		}
	}

	float range;

	void Start () {
		range = 2f;
		// target = GetTarget();
	}

 
  
    void Update()
	{
		Debug.Log(moveSpeed);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		// Time.deltaTime * turnSpeed; 
		float y = 0.20f;
		transform.Rotate(0,y,0);
    }
}