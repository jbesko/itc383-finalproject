using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteKeyAddToInvintory : MonoBehaviour
{
    public GameObject toolSlot;

    void Start () {
        toolSlot.SetActive(false);
    }
    

    void OnCollisionEnter()
    {
        toolSlot.SetActive(true);
        Destroy(gameObject);
    }
}
