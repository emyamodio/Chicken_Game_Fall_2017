using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenHealth : MonoBehaviour {

	public int maxHealth = 5;

	int currentHealth = 0;
	
	public Transform spawnPoint;

	public int points;

	void Start(){
		currentHealth = maxHealth;	
	}
	
	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth<= 0){
			 currentHealth=0;
			 print("Chicken Died!");

			ScoreManager.AddPoints(- points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			currentHealth = maxHealth;
		}
	}
}
