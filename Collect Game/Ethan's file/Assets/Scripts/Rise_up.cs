using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rise_up : MonoBehaviour
{
    GameManager gameManager;
    public Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.levelComplete){            
            if(Input.GetKeyDown("e"))
                animation.Play();
    }
    }
}
