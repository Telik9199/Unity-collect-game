using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private Transform Camera;
    [SerializeField] private GameObject player;
    [SerializeField] private float monster_speed = 5f;
    public Transform target;

    public bool canMove = true;
    // Start is called before the first frame update
    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    { 
        if (canMove == true)
        {
            monster_speed = 5f;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, monster_speed * Time.deltaTime);
        }

        if (canMove == false)
        {
           monster_speed = 0f;
        }
    }
}