using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomFunction : MonoBehaviour {

	int n;

	public GameObject blueObject;
	public GameObject greenObject;
	public GameObject yellowObject;
	public GameObject redObject;
	public GameObject orangeObject;
	public GameObject purpleObject;

	public GameObject GreenTrig;
	public GameObject YellowTrig;
	public GameObject RedTrig;
	public GameObject BlueTrig;
	public GameObject PurpleTrig;
	public GameObject OrangeTrig;
	
	public float speed = 8;



	void OnEnable()
	{
		yellowObject.SetActive(false);
		blueObject.SetActive(false);
		redObject.SetActive(false);
		orangeObject.SetActive(false);
		purpleObject.SetActive(false);
		greenObject.SetActive(false);
		
		GreenTrig.SetActive(false);
		YellowTrig.SetActive(false);
		BlueTrig.SetActive(false);
		PurpleTrig.SetActive(false);
		OrangeTrig.SetActive(false);
		RedTrig.SetActive(false);
	}

	void Update() 
	{
		n=Random.Range(0,6);

		switch(n)
		{
		case 0:
			Debug.Log(n);
			greenObject.SetActive(true);
			greenObject.GetComponent<GoUpGreen>().enabled = true;
           gameObject.SetActive(false);
            break;

		case 1:
			Debug.Log(n);
			yellowObject.SetActive(true);
			yellowObject.GetComponent<GoUpYellow> ().enabled = true;
			gameObject.SetActive(false);
			break;

		case 2:
			Debug.Log(n);
			orangeObject.SetActive(true);
			orangeObject.GetComponent<GoUpOrange> ().enabled = true;
			gameObject.SetActive(false);
			break;

		case 3:

			Debug.Log(n);
			blueObject.SetActive(true);
			blueObject.GetComponent<GoUpBlue> ().enabled = true;
			gameObject.SetActive(false);
			break;
		case 4:
			Debug.Log(n);
			redObject.SetActive(true);
			redObject.GetComponent<GoUpRed> ().enabled = true;
			gameObject.SetActive(false);
			break;

		case 5:

			Debug.Log(n);
			purpleObject.SetActive(true);
			purpleObject.GetComponent<GoUpPurple> ().enabled = true;
			gameObject.SetActive(false);
			break;
	}
	}
}
