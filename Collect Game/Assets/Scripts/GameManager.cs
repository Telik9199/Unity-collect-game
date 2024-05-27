using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text pickupText;
    // Pickup and Level Completion Logic
    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;
    // Auido Logic
    public AudioSource[] audioSources;
    public float audioProximity = 5.0f;

    public void levelCompleteCheck(){
	    if (currentPickups >= maxPickups)
	        levelComplete = true;
	    else
	        levelComplete = false;
    }
    private void UpdateGUI(){
        if (currentPickups >= maxPickups)
            pickupText.text = "All Ingredients have been collected! Return to the hub and press 'e' to continue your quest.";
	    else
            pickupText.text = "Ingredients: " + currentPickups + "/" + maxPickups;
    }    
    
    public void PlayAudioSamples(){
        for(int i = 0; i < audioSources.Length; i++){
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity){
                if(!audioSources[i].isPlaying){
                    audioSources[i].Play();
                }
            }
        }
    }

    // Update is called once per frame
    void Update(){
        levelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }
}
