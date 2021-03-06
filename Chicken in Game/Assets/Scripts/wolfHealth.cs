﻿using System.Collections.Generic;
using UnityEngine;

public class wolfHealth : MonoBehaviour {

	public int currentHealth;

	public int maxHealth = 3;

	public Transform spawnPoint;

	public int points;

	void Start(){
		currentHealth = maxHealth;	
	}

	// Use this for initialization
	public void TakeDamage (int amount) {
		currentHealth -=amount;
		if(currentHealth <= 0){ 
			//KeyValuePair score at zero
			currentHealth=0;
			// Add points to score for killing wolf		
			ScoreManager.AddPoints(points);
			//Move wolf ro spawn point for restart
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			//Reset Wolf Health
			currentHealth = maxHealth;
		}
	}
	
}