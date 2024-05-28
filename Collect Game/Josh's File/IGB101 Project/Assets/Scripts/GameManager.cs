using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text pickupText;
    // Logic for how much is picked up
    public int currentCollected = 0;
    public int maxCollected = 3;
    public bool levelComplete = true;

    public void levelCompleteCheck(){
	    if (currentCollected >= maxCollected)
	        levelComplete = true;
	    else
	        levelComplete = false;
    }
    private void UpdateUI(){
        if (currentCollected >= maxCollected)
            pickupText.text = "You have collected all the crosses! Return to your house and press 'e' to continue!";
	    else
            pickupText.text = "Crosses: " + currentCollected + "/" + maxCollected;
    }    

    // Update is called once per frame
    void Update(){
        levelCompleteCheck();
        UpdateUI();
    }

    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.CompareTag("Player")  && (Input.GetKeyDown("f")) && (levelComplete == true))
        {
            Debug.Log("Next Level");
        }
    }
}
