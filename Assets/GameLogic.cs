using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject winText;
	public int freeSeat = 0;
	public int atDoor = 0;

	void Update () {
		if ( freeSeat == 0 && atDoor == 0){
			winText.SetActive(true);
		}
	}

	public void ReduceFreeSeat(){
		freeSeat --;
	}

	public void GainFreeSeat() {
		freeSeat ++;
	}

	public void ReduceAtDoor() {
		atDoor --;
	}

	public void GainAtDoor() {
		atDoor ++;
	}


}
