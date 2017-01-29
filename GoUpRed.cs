using UnityEngine;
using System.Collections;

public class GoUpRed : MonoBehaviour {

	Vector3 targetPosition;
	Vector3 currentPosition;
	Vector3 directionOfTravel;
	
	public Transform target;
	
	public float speed = 8;
	public GameObject GreenTrig;
	public GameObject YellowTrig;
	public GameObject RedTrig;
	public GameObject BlueTrig;
	public GameObject PurpleTrig;
	public GameObject OrangeTrig;
	
	
	
	void Update()
	{
		targetPosition = target.transform.position; // Get position of object B
		currentPosition = this.transform.position; // Get position of object A
		directionOfTravel = targetPosition - currentPosition;
		
		if (Vector3.Distance (currentPosition, targetPosition) >.1f) {
			this.transform.Translate (
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
		} 
		else 
		{
			GreenTrig.SetActive (true);
			YellowTrig.SetActive (true);
			BlueTrig.SetActive (true);
			PurpleTrig.SetActive (true);
			OrangeTrig.SetActive (true);
			RedTrig.SetActive (true);
			gameObject.GetComponent<GoUpRed> ().enabled = false;
			
			
			
		} 
	}
}

