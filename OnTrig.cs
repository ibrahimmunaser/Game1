using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnTrig : MonoBehaviour {

	ParticleSystem particle;

	public GameObject GreenTrig;
	public GameObject YellowTrig;
	public GameObject RedTrig;
	public GameObject BlueTrig;
	public GameObject PurpleTrig;
	public GameObject OrangeTrig;

	public GameObject Purple;
	public GameObject Green;
	public GameObject Blue;
	public GameObject Red;
	public GameObject Orange;
	public GameObject Yellow;
	public GameObject randomize;
	public int count=0;
	public int count1=0;
	float timeLeft = 3.0f;



	void OnMouseDown() 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if(Green.activeSelf)
			{
				Green.GetComponent<Envelope> ().enabled = true;
				Red.GetComponent<Envelope>() .enabled=false;
				Blue.GetComponent<Envelope>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=false;
				Yellow.GetComponent<Envelope>() .enabled=false;
			}
			else if(Yellow.activeSelf)
			{

				Green.GetComponent<Envelope> ().enabled = false;
				Red.GetComponent<Envelope>() .enabled=false;
				Blue.GetComponent<Envelope>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=false;
				Yellow.GetComponent<Envelope>() .enabled=true;
			}
			else if(Purple.activeSelf)
			{
				Yellow.GetComponent<Envelope>() .enabled=false;
				Green.GetComponent<Envelope> ().enabled = false;
				Red.GetComponent<Envelope>() .enabled=false;
				Blue.GetComponent<Envelope>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=true;
			}
			else if(Blue.activeSelf)
			{
				Yellow.GetComponent<Envelope>() .enabled=false;
				Green.GetComponent<Envelope> ().enabled = false;
				Red.GetComponent<Envelope>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=false;
				Blue.GetComponent<Envelope>() .enabled=true;
			}
			else if(Orange.activeSelf)
				{
				Yellow.GetComponent<Envelope>() .enabled=false;
				Green.GetComponent<Envelope> ().enabled = false;
				Red.GetComponent<Envelope>() .enabled=false;
				Blue.GetComponent<Envelope>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=true;
			}
			else if(Red.activeSelf)
			{
				Yellow.GetComponent<Envelope>() .enabled=false;
				Green.GetComponent<Envelope> ().enabled = false;
				Blue.GetComponent<Envelope>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=false;
				Red.GetComponent<Envelope>() .enabled=true;
			}
		}
}
	void OnTriggerEnter(Collider col)
	{

		if (col.gameObject.tag == "Green") {

			Scorecount.count += 1;
			
			
			if (Scorecount.count % 10==0) {
				Scorecount.count+=10;
			}
			timeLeft -= Time.deltaTime;
			//if(timeLeft < 0)
			//{
			//	gameObject.GetComponent<Audio3>().enabled=false;
			//}
			Debug.Log("Counter: "+counter.count1);

			gameObject.GetComponent<Scorecount>().Display();


			Debug.Log(Scorecount.count);

			YellowTrig.GetComponent<AUDIO2>().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = false;
			OrangeTrig.GetComponent<AUDIO2>().enabled = false;
			PurpleTrig.GetComponent<AUDIO2>().enabled = false;
			RedTrig.GetComponent<AUDIO2>().enabled = false;
			GreenTrig.GetComponent<AUDIO2>().enabled = false;

			GreenTrig.GetComponent<AUDIO>().enabled = true;
			OrangeTrig.GetComponent<AUDIO>().enabled = false;
			BlueTrig.GetComponent<AUDIO>().enabled = false;
			YellowTrig.GetComponent<AUDIO>().enabled = false;
			PurpleTrig.GetComponent<AUDIO>().enabled = false;
			RedTrig.GetComponent<AUDIO>().enabled = false;

			Debug.Log("GREEN SOUND ON");
			Green.GetComponent<Envelope> ().enabled = false;
			Green.GetComponent<GoUpGreen> ().enabled = false;
			Green.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Green.transform.rotation = Quaternion.Euler(90,0,0);

		}
		else if (col.gameObject.tag == "Yellow") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2>().enabled = true;

			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Yellow.GetComponent<Envelope> ().enabled = false;
			Yellow.GetComponent<GoUpYellow> ().enabled = false;
			Yellow.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Yellow.transform.rotation = Quaternion.Euler(90,0,0);
			Yellow.SetActive(false);

		}
		else if(col.gameObject.tag == "Purple")
		{
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2>().enabled = true;

			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Purple.GetComponent<Envelope> ().enabled = false;
			Purple.GetComponent<GoUpPurple> ().enabled = false;
			Purple.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Purple.transform.rotation = Quaternion.Euler(90,0,0);
			Purple.SetActive(false);

		
		}
		else if (col.gameObject.tag == "Red") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO2>().enabled = true;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Red.GetComponent<Envelope> ().enabled = false;
			Red.GetComponent<GoUpRed >().enabled = false;
			Red.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Red.transform.rotation = Quaternion.Euler(90,0,0);
			Red.SetActive(false);

			
		}
		else if (col.gameObject.tag == "Orange") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO2>().enabled = true;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Orange.GetComponent<Envelope> ().enabled = false;
			Orange.GetComponent<GoUpOrange> ().enabled = false;
			Orange.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Orange.transform.rotation = Quaternion.Euler(90,0,0);
			Orange.SetActive(false);


		}
		else if (col.gameObject.tag == "Blue") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO2>().enabled = true;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Blue.GetComponent<Envelope> ().enabled = false;
			Blue.GetComponent<GoUpBlue> ().enabled = false;
			Blue.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Blue.transform.rotation = Quaternion.Euler(90,0,0);
			Blue.SetActive(false);
			
		}

		randomize.SetActive (true);
		randomize.GetComponent<RandomFunction> ().enabled = true;
		
	}


}