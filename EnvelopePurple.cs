using UnityEngine;
using System.Collections;

public class EnvelopePurple : MonoBehaviour
{
	public float speed = 6;
	Vector3 targetPosition;
	Vector3 currentPosition;
	Vector3 directionOfTravel ;
	public Transform target;

	public GameObject Green;
	public GameObject Blue;
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

			Yellow.SetActive(false);
			Orange.SetActive(false);
			Green.SetActive(false);
			Red.SetActive(false);
			Blue.SetActive(false);

		}

	}
}

