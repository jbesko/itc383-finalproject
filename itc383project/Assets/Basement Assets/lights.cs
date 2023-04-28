using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lights : MonoBehaviour
{
   // public GameObject txtToDisplay;

    private bool PlayerInZone;

    public GameObject lightorobj;

    private void Start()
    {

      //  PlayerInZone = false;
      //  txtToDisplay.SetActive(false);

    }

    private void Update()
    {
        if (PlayerInZone)
        {
            lightorobj.SetActive(!lightorobj.activeSelf);

        }
    }

   // private void OnCollisionEnter()
  // {
      
        
       //    PlayerInZone = false;
        //   txtToDisplay.SetActive(false);
        
 // }
}

//&& Input.GetKeyDown(KeyCode.A)