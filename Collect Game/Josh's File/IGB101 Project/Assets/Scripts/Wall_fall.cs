using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_fall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }
}
