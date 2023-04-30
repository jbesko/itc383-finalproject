using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrandmaHitsYou : MonoBehaviour
{
    public string sceneName;
    private int[] hitCount = new int[2];
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter ()
    {
        if (hitCount[0] == 0){
            hitCount[0] = 1;
        } else {
            SceneManager.LoadScene(sceneName);
        }
    }
}
