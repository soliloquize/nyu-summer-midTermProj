using UnityEngine;
using System.Collections;

public class AtDoorScript : MonoBehaviour {

	public GameLogic logic;
	
	void OnTriggerEnter ( Collider c ) {
		if (c.transform.tag == "Passenger") {
			logic.GainAtDoor();
		}
	}

	void OnTriggerExit (Collider c ) {
		if (c.transform.tag == "Passenger") {
			logic.ReduceAtDoor();
		}
	}

}
