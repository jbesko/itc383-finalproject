using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;
    public GameObject KeySlot;

    void OnCollisionEnter () 
    {
        if (KeySlot.activeInHierarchy == true)  {
            SceneManager.LoadScene(sceneName);
        } else {

        }
        
    }

}
