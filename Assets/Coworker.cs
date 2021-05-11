using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Coworker : MonoBehaviour
{
Rigidbody rb;
	
	float xInput;
	float zInput;  
	public float speed;

	// Start is called before the first frame update
	void Start()
	{
		//public float speed;
		rb = GetComponent<Rigidbody>();
		
	}

	// Update is called once per frame
	void Update()
	{
		if( Input.GetKeyDown( KeyCode.Space ))
		{
			//Destroy( gameObject );
			rb.AddForce( Vector3.up * 500 );
		}
		xInput = Input.GetAxis("Horizontal");
		zInput = Input.GetAxis("Vertical");

		rb.AddForce( zInput * speed, 0, xInput * speed );
	}

}
