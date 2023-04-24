using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyAdding : MonoBehaviour
{
    public GameObject textBox;
    void OnCollisionEnter () 
    {
        textBox.GetComponent<Text>().text += "*";
        Destroy(gameObject);
    }


}
