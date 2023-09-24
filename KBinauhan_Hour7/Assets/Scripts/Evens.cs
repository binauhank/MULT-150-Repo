using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    int number = 101;


    void Start()
    {
        for(int i = 22; i < number; i = i + 2)
        {
            Debug.Log("Even number: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
