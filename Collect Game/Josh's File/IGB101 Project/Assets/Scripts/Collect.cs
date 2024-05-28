using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    GameManager GameManager;
    public AudioSource Holy;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)
    {
            Holy.Play();
            GameManager.currentCollected += 1;
            Destroy(gameObject);

    }
}
