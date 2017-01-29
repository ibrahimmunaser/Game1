using UnityEngine;
using System.Collections;

public class OnTrigBlue : MonoBehaviour {
	
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
	public GameObject script;

	private int count1;
	float timeLeft = 3.0f;

	void OnMouseDown() 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if(Green.activeSelf)
			{
				Green.GetComponent<EnvelopeBlue> ().enabled = true;
				Green.GetComponent<EnvelopeRed>().enabled=false;
				Green.GetComponent<EnvelopeOrange>().enabled=false;
				Green.GetComponent<EnvelopeYellow>().enabled=false;
				Green.GetComponent<EnvelopePurple>().enabled=false;
				Green.GetComponent<Envelope>().enabled=false;
			}
			else if(Yellow.activeSelf)
			{
				Yellow.GetComponent<EnvelopeBlue> ().enabled = true;
				Yellow.GetComponent<EnvelopeRed>().enabled=false;
				Yellow.GetComponent<EnvelopeOrange>() .enabled=false;
				Yellow.GetComponent<EnvelopeYellow>() .enabled=false;
				Yellow.GetComponent<EnvelopePurple>() .enabled=false;
				Yellow.GetComponent<Envelope>() .enabled=false;
			}
			else if(Purple.activeSelf)
			{
				Purple.GetComponent<EnvelopeBlue> ().enabled = true;
				Purple.GetComponent<EnvelopeRed>().enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopePurple>() .enabled=false;
				Purple.GetComponent<Envelope>() .enabled=false;
			}

			else if(Blue.activeSelf)
			{
				Blue.GetComponent<EnvelopeBlue> ().enabled = true;
				Blue.GetComponent<EnvelopeRed>().enabled=false;
				Blue.GetComponent<EnvelopeOrange>() .enabled=false;
				Blue.GetComponent<EnvelopeYellow>() .enabled=false;
				Blue.GetComponent<EnvelopePurple>() .enabled=false;
				Blue.GetComponent<Envelope>() .enabled=false;
			}
			else if(Orange.activeSelf)
			{
				Orange.GetComponent<EnvelopeBlue> ().enabled = true;
				Orange.GetComponent<EnvelopeRed>().enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopePurple>() .enabled=false;
				Orange.GetComponent<Envelope>() .enabled=false;
			}
			else if(Red.activeSelf)
			{
				Red.GetComponent<EnvelopeBlue> ().enabled = true;
				Red.GetComponent<EnvelopeRed>().enabled=false;
				Red.GetComponent<EnvelopeOrange>() .enabled=false;
				Red.GetComponent<EnvelopeYellow>() .enabled=false;
				Red.GetComponent<EnvelopePurple>() .enabled=false;
				Red.GetComponent<Envelope>() .enabled=false;
			}
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.tag == "Blue") {

			Scorecount.count += 1;
			
			
			if (Scorecount.count % 10==0) {
				Scorecount.count+=10;
			}
			timeLeft -= Time.deltaTime;
			//if(timeLeft < 0)
			//{
			//	gameObject.GetComponent<Audio3>().enabled=false;
			//}
			gameObject.GetComponent<Scorecount>().Display ();

			Debug.Log(Scorecount.count);

			BlueTrig.GetComponent<AUDIO> ().enabled = true;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			OrangeTrig.GetComponent<AUDIO2>().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;



			Debug.Log("BLUE SOUND ON");
			Blue.GetComponent<EnvelopeBlue> ().enabled = false;
			Blue.GetComponent<GoUpBlue> ().enabled = false;
			Blue.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Blue.transform.rotation = Quaternion.Euler(90,0,0);

		}

		else if (col.gameObject.tag == "Yellow") {
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			Yellow.GetComponent<EnvelopeBlue> ().enabled = false;
			Yellow.GetComponent<GoUpYellow> ().enabled = false;
			Yellow.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Yellow.transform.rotation = Quaternion.Euler(90,0,0);
	
		}
		else if(col.gameObject.tag == "Purple")
		{
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Purple.GetComponent<EnvelopeBlue> ().enabled = false;
			Purple.GetComponent<GoUpPurple> ().enabled = false;
			Purple.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Purple.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Red") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Red.GetComponent<EnvelopeBlue> ().enabled = false;
			Red.GetComponent<GoUpRed> ().enabled = false;
			Red.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Red.transform.rotation = Quaternion.Euler(90,0,0);
			
		}
		else if (col.gameObject.tag == "Orange") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;
		

			Orange.GetComponent<EnvelopeBlue> ().enabled = false;
			Orange.GetComponent<GoUpOrange> ().enabled = false;
			Orange.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Orange.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Green") {
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;
			
			Green.GetComponent<EnvelopeBlue> ().enabled = false;
			Green.GetComponent<GoUpGreen> ().enabled = false;
			Green.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Green.transform.rotation = Quaternion.Euler(90,0,0);
		}
	
		randomize.SetActive (true);
		randomize.GetComponent<RandomFunction> ().enabled = true;
	}
}