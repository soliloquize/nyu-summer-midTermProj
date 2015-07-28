using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed = 10f;
	public float flySpeed = 10f;

	public GameObject[] passengerList;
	public GameObject fairy;

	public GameObject pounchBox;

	void Start() {
		passengerList = GameObject.FindGameObjectsWithTag ("Passenger");
	}

	void FixedUpdate () {

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical"); 
		

		Rigidbody rbody = GetComponent<Rigidbody>();
		rbody.AddRelativeForce (x * speed * Time.deltaTime, 0f, y * speed * Time.deltaTime );
		//transform.rotation = Vector3.forward
		if (Input.GetKey(KeyCode.Space)){
			rbody.AddRelativeForce ( 0f, flySpeed * Time.deltaTime, 0f);
		}

		if(Input.GetKey(KeyCode.W)){
			fairy.transform.forward = new Vector3( 0f, 0f, 1f );
		}
		
		if(Input.GetKey(KeyCode.S)){
			fairy.transform.forward = new Vector3( 0f, 0f, -1f );	
		}
		
		if(Input.GetKey(KeyCode.A)){
			fairy.transform.forward = new Vector3 ( -1f, 0f, 0f);
		}
		
		if(Input.GetKey(KeyCode.D)){
			fairy.transform.forward = new Vector3( 1f, 0f, 0f );
		}

		//BoxCollider col = GetComponent<BoxCollider>();
		//collider col = GetComponent<Collider>();
		if (Input.GetMouseButton (0) ){
			pounchBox.SetActive(true);
			//col.size = new Vector3 (3f, 2f, 3f);
		} else {
			pounchBox.SetActive(false);
			//col.size = new Vector3 (1f, 2f, 1f);
		}


		float drawPower = 0.01f;
		float drawDistance = 10f;

		if (Input.GetMouseButton (1) ) {
			foreach (GameObject p in passengerList){
				float dis = Vector3.Distance (p.transform.position, gameObject.transform.position);
				if (dis <= drawDistance) {
					p.transform.position = Vector3.Lerp (p.transform.position, gameObject.transform.position, drawPower);
				}
			}
		}
	}
}
