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
			transform.LookAt(2 * other.gameObject.transform.position - transform.position);
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
			ScoreManager.Count();


		}
	}

	float range;

	void Start () {
		range = 2f;
		// target = GetTarget();
		// transform.rotation = new Quaternion(transform.rotation.x,Random.Range(-180,180),transform.rotation.z,transform.rotation.w);
	}

 
  
    // void Update()
	// {
	// 	// Debug.Log(moveSpeed);
    //     transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	// 	// Time.deltaTime * turnSpeed; 
		
	// transform.Rotate(0,Random.Range(-180,180) * Time.deltaTime,0);
	

    // }
}