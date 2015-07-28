using UnityEngine;
using System.Collections;

public class SeatScript : MonoBehaviour {

	public GameLogic logic;

	void OnTriggerEnter (Collider c) {
		if (c.transform.tag == "Passenger") {
		logic.ReduceFreeSeat();
		}
	}

	void OnTriggerExit (Collider c) {
		if (c.transform.tag == "Passenger") {
		logic.GainFreeSeat();
		}
	}
	
}
