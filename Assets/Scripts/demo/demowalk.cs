using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demowalk : MonoBehaviour
{
    private Animator anim;
    private bool stop;
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            stop = !stop;
            anim.SetBool("stopwalk",stop);
        }
        
    }
}
