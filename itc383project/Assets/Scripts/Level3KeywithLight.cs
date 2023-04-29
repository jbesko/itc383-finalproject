using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3KeywithLight : MonoBehaviour
{
    public GameObject toolSlot;
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        toolSlot.SetActive(false);
    }

    void OnCollisionEnter()
    {
        if(light.intensity == 5){
        toolSlot.SetActive(true);
        Destroy(gameObject);
        }
    }
}
