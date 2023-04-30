using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Congrats : MonoBehaviour {

    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToFirstLevel() {
        SceneManager.LoadScene(2);
    }

    public void BackToMainMenu ()  {
        SceneManager.LoadScene(0);
    }
}
