using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteGameObject : MonoBehaviour
{
    Renderer test;
    public GameObject toolSlot;

    void Start () {
        toolSlot.SetActive(false);
    }
    

    void OnCollisionEnter()
    {
        test = GetComponent<MeshRenderer>();
        test.enabled = false;
        toolSlot.SetActive(true);
    }
}
