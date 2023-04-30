using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    private ScoreManager theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        theScoreManager.scoreIncreasing = false;
        

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

    
}
