using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;
    public GameObject textBox;

    void OnCollisionEnter () 
    {
        string text = textBox.GetComponent<Text>().text;
        if (text == "*")  {
            Debug.Log("NextScene");
            SceneManager.LoadScene(sceneName);
        } else {

        }
        
    }

}
