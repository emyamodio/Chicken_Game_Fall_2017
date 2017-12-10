using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class win : MonoBehaviour {
    public int winScore;
    public GameObject scoreManager;
    int currentScore; 
    public Text winText;



    // Use this for initialization
    void Start () {
    winText.GetComponent<Text>().enabled = false;   
    
    }
    
    // Update is called once per frame
    void Update () {
        currentScore = scoreManager.gameObject.GetComponentInChildren<ScoreManager>().scoreAmount;
        Debug.Log(currentScore + " - " + winScore + " - " + (currentScore >= winScore));
        if (currentScore >= winScore){
			print("Current Score ="+ currentScore);
            winText.GetComponent<Text>().enabled = true;    
        }
    }
}