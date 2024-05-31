using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class PickUp : MonoBehaviour
{
    GameManager gameManager;
    public int worth = 1;
    //public AudioClip chime;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        //GetComponent<AudioSource>().playOnAwake = false;
       // GetComponent<AudioSource>().clip = chime;
    }

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.transform.tag == "Player")
        {
            gameManager.currentPickups += worth;
            Destroy(this.gameObject);
           // GetComponent<AudioSource>().Play();
        }
    }

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
        //GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

