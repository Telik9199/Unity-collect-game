using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_3 : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.currentCollected >= 2)
        {
            Destroy(gameObject);
        }
    }
}
