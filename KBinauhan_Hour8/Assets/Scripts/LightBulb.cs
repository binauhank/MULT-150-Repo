using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    Light lightComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        bool isKeyDown = Input.GetKey(KeyCode.L);
        lightComponent = GetComponent<Light> ();
        lightComponent.type = LightType.Point;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
            lightComponent.enabled = true;
        else
            lightComponent.enabled = false;
    }
}
