using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    int month = 13; int day = 32;

    
    void Start()
    {
        for(int i = 1; i < month; i++)
        {
            Debug.Log ("Month: " + i); if (i == 10)
            {
                Debug.Log ("It's my birthday!");
            }
        }
        for(int x = 1; x < day; x++)
        {
            Debug.Log ("Day: " + x); if (x == 22)
            {
                Debug.Log ("It's my birthday!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
