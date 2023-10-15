using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    int x = 1;
    void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " Collision number: " + x++);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
