using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatInvisable : MonoBehaviour
{
    Renderer test1;
    Renderer test2;
    public GameObject groundBat;

    void Start()
    {
        test1 = GetComponent<MeshRenderer>();
        test1.enabled = false;
        test2 = groundBat.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (test2.enabled == false) {
            test1.enabled = true;
        }
    }
    

}
