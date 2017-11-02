using UnityEngine;
using System.Collections;


public class WolfAI : MonoBehaviour {
	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;

	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
	
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
									   //back//
	}
}
	void OnCollisionEnter(Collision other)
	{
		
		print("Wolf is attacking");
		var hit = other.gameObject;
		var health = hit.GetComponent<playerHealth>();

		if(health != null){
			health.TakeDamage(damage);
		
	}
}
	public static Vector3 RandomNavSphere (Vector3 origin, float distance, int layermask) {
            Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * distance;
           
            randomDirection += origin;
           
		    UnityEngine.AI.NavMeshHit navHit;
                       
            UnityEngine.AI.NavMesh.SamplePosition (randomDirection, out navHit, distance, layermask);
           
            return navHit.position;
        }
	
}