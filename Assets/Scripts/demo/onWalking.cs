using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class onWalking : MonoBehaviour
{
    private Animator _animator;

    private bool walking;
    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            walking = !walking;
            _animator.SetBool("walking",walking);
        }
    }
}
