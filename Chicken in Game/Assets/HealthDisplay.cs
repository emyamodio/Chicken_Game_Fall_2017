using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {

	public GameObject player;
	public playerHealth playerHP;
	public Text displayedHP;

	// Use this for initialization
	void Start () {
		playerHP = player.GetComponent<playerHealth>();
		displayedHP = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		displayedHP.text = playerHP.currentHealth.ToString(); 
	}
}
