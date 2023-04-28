using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff : MonoBehaviour
{
    public GameObject txtToDisplay;

    private bool PlayerInZone;

  //  public GameObject lightorobj;

    private void Start()
    {

        PlayerInZone = false;
        txtToDisplay.SetActive(false);

    }

   // private void Update()
   // {
   //     if (PlayerInZone && Input.GetKeyDown(KeyCode.F))
    //    {
     //       lightorobj.SetActive(!lightorobj.activeSelf);
//
    //    }
  //  }

    private void OnCollisionEnter()
    {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
    
    }

    private void OnCollisionExit()
    {
            txtToDisplay.SetActive(false);
            PlayerInZone = false;
    
    }


}
