using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SeatCount : MonoBehaviour {

	public GameObject cam;
	int free = 0;
	int atDoor = 0;

	void Update(){
		free = cam.GetComponent<GameLogic>().freeSeat;
		atDoor = cam.GetComponent<GameLogic>().atDoor;
		GetComponent<Text>().text = "Free Seat Remaining : " + free.ToString() 
			+ "\nPeople In Front Of The Doors : " + atDoor.ToString()
			+ "\nLeft mouse to push people"
			+ "\nRight mouse to draw people!"; 
	}



}
