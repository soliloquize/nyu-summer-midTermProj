using UnityEngine;
using System.Collections;

public class SeatScript : MonoBehaviour {

	public GameLogic logic;

	void OnTriggerEnter () {
		logic.ReduceFreeSeat();
	}
}
