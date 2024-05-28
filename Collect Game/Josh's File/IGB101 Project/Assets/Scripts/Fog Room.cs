using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogRoom : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.transform.tag == "Player")
        {
            RenderSettings.fog = true;
        }
    }

    private void OnTriggerExit(Collider otherObject)
    {
        if(otherObject.transform.tag == "Player")
        {
            RenderSettings.fog = false;
        }
    }

}
