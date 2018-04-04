using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Force;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        print("postojim");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("skacem");
            _rb.AddForce(Force * Vector2.up);

        }
    }
}

