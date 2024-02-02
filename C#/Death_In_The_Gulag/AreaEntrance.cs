using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName; 
    void Start()
    {
     if(transitionName == PlayerController.instance.areaTransitionName)
     {
        PlayerController.instance.transform.position = transform.position; 
     }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
