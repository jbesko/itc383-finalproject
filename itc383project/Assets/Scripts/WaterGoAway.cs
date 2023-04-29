using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGoAway : MonoBehaviour
{
    public GameObject obj;
    public Animator anim1;
    public Animator anim2;
    Renderer test;
    
    void Start()
    {
        anim1.enabled = false;
        anim2.enabled = false;
        test = obj.GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter()
    {
        if(test.enabled == true)
        {
            anim1.enabled = true;
            anim2.enabled = true;
        }
        
    }
    
}
