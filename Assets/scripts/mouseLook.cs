using UnityEngine;
using System.Collections;

public class mouseLook : MonoBehaviour {

	public GameObject cam;
	public float rotateSpeedX;
	public float rotateSpeedY;

	float rotationY = 0f;

	void Update () {
	
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");

		transform.Rotate (0f, mouseX * rotateSpeedX * Time.deltaTime , 0f);
		//cam.transform.Rotate ( -mouseY * rotateSpeedY * Time.deltaTime , 0f, 0f); // not correct 


		//CLAMPED Y-LOOK
		// 1. modify pitch
		rotationY -= mouseY * rotateSpeedY;

		// 2. correct pitch / clamp it
		rotationY = Mathf.Clamp ( rotationY , -80f, 80f); //clamp means if the number >max or <min, set to max or min

		// 3. apply the pitch to the camera
		cam.transform.localEulerAngles = new Vector3 ( rotationY , 0f , 0f );

	}

	void FixedUpdate(){



	}
}
