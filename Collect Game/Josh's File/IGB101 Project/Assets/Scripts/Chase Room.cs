using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseRoom : MonoBehaviour
{
    public Monster Monster;
    
    void Start()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Monster.canMove = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Monster.canMove = false;
        }
    }
}
