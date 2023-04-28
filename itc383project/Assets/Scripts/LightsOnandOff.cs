using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class LightsOnandOff : MonoBehaviour
{
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        light.intensity=0;
    }

    // Update is called once per frame
    void OnCollisionStay() 
    {
        if(Input.GetKeyDown(KeyCode.F)){

            light.intensity=5;
        }
    }
}
