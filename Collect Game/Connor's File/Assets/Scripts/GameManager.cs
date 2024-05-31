using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    public GameObject player;

    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public Text pickupText;

    //audio promixmity logic
    public AudioSource[] audioSources;
    public float audioProximity = 1.0f;

    // Update is called once per frame
    void Update()
    {
        LevelCompleteCheck();
        UpdateGUI();
        PlayAudioSamples();
    }

    private void LevelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }

    public void UpdateGUI()
    {
        pickupText.text = "Pickups: " + currentPickups + "/" + maxPickups;
    }


    ///Loop for playing audio proximity events - AudioSource based
    private void PlayAudioSamples(){
        for (int i = 0; i < audioSources.Length; i++)
        {
            if(Vector3.Distance(player.transform.position, audioSources[i].transform.position) <= audioProximity)
            {
                if (!audioSources[i].isPlaying)
                {
                    audioSources[i].Play();
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
