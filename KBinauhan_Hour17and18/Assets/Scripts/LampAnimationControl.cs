using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampAnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool ("Color", Input.GetKey(KeyCode.A));
        anim.SetBool ("Scale", Input.GetKey(KeyCode.D));
        anim.SetBool ("Spin", Input.GetKey(KeyCode.S));
        anim.SetBool ("Hover", Input.GetKey(KeyCode.W));
    }
}
