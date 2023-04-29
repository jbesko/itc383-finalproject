using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteGameObject : MonoBehaviour
{
    Renderer test;

    void OnCollisionEnter()
    {
        test = GetComponent<MeshRenderer>();
        test.enabled = false;
    }
}
