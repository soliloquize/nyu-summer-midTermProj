using UnityEngine;
using System.Collections;

public class AtDoorScript : MonoBehaviour {

	public GameLogic logic;
	
	void OnTriggerEnter () {
		logic.GainAtDoor();
	}

	void OnTriggerExit () {
		logic.ReduceAtDoor();
	}

}
