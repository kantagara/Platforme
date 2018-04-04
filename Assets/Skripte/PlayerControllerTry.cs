using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTry : MonoBehaviour {

    public float MoveSpeed;
    public float JumpHeight;

    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask WhatIsGround;
    private bool _grounded;

    private bool DoubleJumped; 
  

    // Use this for initialization
    void Start ()
    {
        

    }


    void FixedUpdate()
    {
        _grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
    }
	
	
    // Update is called once per frame
	void Update ()
	{

	    if (_grounded)
	        DoubleJumped = false;


	    if (Input.GetKeyDown(KeyCode.Space) && _grounded)
	    {
	        
        
           GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);

	    }

	    if (Input.GetKeyDown(KeyCode.Space) && !DoubleJumped && !_grounded)
	    {

	        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	        DoubleJumped = true;
	    }
        if (Input.GetKey(KeyCode.D))
	    {

	        GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);

	    }

	    if (Input.GetKey(KeyCode.A))
	    {

	        GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	    }
    }
}



