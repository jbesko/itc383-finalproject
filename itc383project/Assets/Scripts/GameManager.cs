using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager theScoreManager;
    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<SocreManager>();
    }

    // Update is called once per frame
    public IEnumerator RestartGameCo()
    {
        
        theScoreManager.scoreIncreasing = false;

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
}
