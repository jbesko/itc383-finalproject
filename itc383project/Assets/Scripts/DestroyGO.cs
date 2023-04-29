using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGO : MonoBehaviour
{
    Renderer test;
    public GameObject obj;
    
    void Start() 
    {
        test = obj.GetComponent<MeshRenderer>();
    }
    

    void OnCollisionEnter () 
    {
        if(test.enabled == true)
        {
            Destroy(gameObject);
        }
        
    }
}
