using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Horizontal") / 10;
        transform.Translate(mX, 0, 0);
    }
}
