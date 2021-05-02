using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Coworker : MonoBehaviour
{

	//RigidBody rb;

	// Start is called before the first frame update
	void Start()
	{
		//rb = GetCompnent<RigidBody>();
	}

	// Update is called once per frame
	void Update()
	{
		if( Input.GetKeyDown( KeyCode.Space ))
		{
			Destroy( gameObject );
		}
	}

}
