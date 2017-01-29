
using UnityEngine;
using System.Collections;

public class EnvelopeBlue : MonoBehaviour
{
	public float speed = 6;
	Vector3 targetPosition;
	Vector3 currentPosition;
	Vector3 directionOfTravel ;

	public Transform target;
	public GameObject Purple;
	public GameObject Green;
	public GameObject Red;
	public GameObject Orange;
	public GameObject Yellow;


	

	void Update()
	{
		targetPosition = target.transform.position; // Get position of object B
		currentPosition = this.transform.position; // Get position of object A
		directionOfTravel = targetPosition - currentPosition;
		if (Vector3.Distance (currentPosition, targetPosition) > .1f) {
			this.transform.Translate (
				(directionOfTravel.x * speed * Time.deltaTime),
				(directionOfTravel.y * speed * Time.deltaTime),
				(directionOfTravel.z * speed * Time.deltaTime),
				Space.World);
			transform.Rotate (new Vector3 (Time.deltaTime * 400, 0, 0));

			Purple.SetActive(false);
			Orange.SetActive(false);
			Green.SetActive(false);
			Purple.SetActive(false);
			Yellow.SetActive(false);

		} 

}

}