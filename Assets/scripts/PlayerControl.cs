using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed = 10f;
	public float flySpeed = 10f;

	void FixedUpdate () {

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical"); 
		

		Rigidbody rbody = GetComponent<Rigidbody>();
		rbody.AddRelativeForce (x * speed * Time.deltaTime, 0f, y * speed * Time.deltaTime );

		if (Input.GetKey(KeyCode.Space)){
			rbody.AddRelativeForce ( 0f, flySpeed * Time.deltaTime, 0f);
		}

	}
}
