using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;

    void OnCollisionEnter () 
    {
        Debug.Log("NextScene");
        SceneManager.LoadScene(sceneName);
    }

}
