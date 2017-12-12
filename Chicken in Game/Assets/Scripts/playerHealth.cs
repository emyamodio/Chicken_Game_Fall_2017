using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

	public const int maxHealth = 50;
	public int currentHealth = maxHealth;
	public Text hp;
	public Text maxHP;

	void Start () {
		hp = hp.GetComponent<Text>();
		maxHP = maxHP.GetComponent<Text>();
	}
		
	// Update is called once per frame
	void Update () {
		hp.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth<= 0){
			 currentHealth=0;
			 print("you're dead! Game Over");

	SceneManager.LoadScene(0);

		}
	
	if(currentHealth == 0){
		/*Destroy(gomaObgject); */
		ScoreManager.AddPoints(0);

		}
	}

}
		
