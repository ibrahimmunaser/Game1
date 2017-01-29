using UnityEngine;
using System.Collections;

public class OnTrigYellow : MonoBehaviour {
	
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
	float timeLeft = 3.0f;


	void OnMouseDown() 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if(Green.activeSelf)
			{
				Yellow.GetComponent<EnvelopeYellow>().enabled=false;
				Red.GetComponent<EnvelopeYellow>() .enabled=false;
				Blue.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=false;
				Green.GetComponent<EnvelopeYellow> ().enabled = true;

			}
			else if(Yellow.activeSelf)
			{
				Green.GetComponent<EnvelopeYellow> ().enabled = false;
				Red.GetComponent<EnvelopeYellow>() .enabled=false;
				Blue.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=false;
				Yellow.GetComponent<EnvelopeYellow>() .enabled=true;

			}
			else if(Purple.activeSelf)
			{
				Yellow.GetComponent<EnvelopeYellow>() .enabled=false;
				Green.GetComponent<EnvelopeYellow> ().enabled = false;
				Red.GetComponent<EnvelopeYellow>() .enabled=false;
				Blue.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=true;
			}
			else if(Blue.activeSelf)
			{
				Yellow.GetComponent<EnvelopeYellow>() .enabled=false;
				Green.GetComponent<EnvelopeYellow> ().enabled = false;
				Red.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=false;
				Blue.GetComponent<EnvelopeYellow>() .enabled=true;
			}
			else if(Orange.activeSelf)
			{
				Yellow.GetComponent<EnvelopeYellow>() .enabled=false;
				Green.GetComponent<EnvelopeYellow> ().enabled = false;
				Red.GetComponent<EnvelopeYellow>() .enabled=false;
				Blue.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=true;
			}
			else if(Red.activeSelf)
			{
				Yellow.GetComponent<EnvelopeYellow>() .enabled=false;
				Green.GetComponent<EnvelopeYellow> ().enabled = false;
				Red.GetComponent<EnvelopeYellow>() .enabled=true;
				Blue.GetComponent<EnvelopeYellow>() .enabled=false;
				Orange.GetComponent<EnvelopeYellow>() .enabled=false;
				Purple.GetComponent<EnvelopeYellow>() .enabled=false;
			}
		}
	}
	void OnTriggerEnter(Collider col)
	{
		
		 if (col.gameObject.tag == "Yellow") {

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
			Debug.Log("yellow SOUND ON");
			
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled =false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;
			
			YellowTrig.GetComponent<AUDIO> ().enabled = true;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;
			
			Yellow.GetComponent<EnvelopeYellow> ().enabled = false;
			Yellow.GetComponent<GoUpYellow> ().enabled = false;
			Yellow.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Yellow.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Green") {



			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = true;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;


			Green.GetComponent<EnvelopeYellow> ().enabled = false;
			Green.GetComponent<GoUpGreen> ().enabled = false;
			Green.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Green.transform.rotation = Quaternion.Euler(90,0,0);	
		}

		else if(col.gameObject.tag == "Purple")
		{
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = true;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Purple.GetComponent<EnvelopeYellow> ().enabled = false;
			Purple.GetComponent<GoUpPurple> ().enabled = false;
			Purple.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Purple.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Red") {
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = true;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;


			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Red.GetComponent<EnvelopeYellow> ().enabled = false;
			Red.GetComponent<GoUpRed> ().enabled = false;
			Red.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Red.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Orange") {
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = true;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			gameObject.GetComponent<AUDIO>().enabled=false;
			Orange.GetComponent<EnvelopeYellow> ().enabled = false;
			Orange.GetComponent<GoUpOrange> ().enabled = false;
			Orange.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Orange.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Blue") {

			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO2> ().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = true;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;
			Blue.GetComponent<EnvelopeYellow> ().enabled = false;
			Blue.GetComponent<GoUpBlue> ().enabled = false;
			Blue.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Blue.transform.rotation = Quaternion.Euler(90,0,0);
			
		}

		randomize.SetActive (true);
		randomize.GetComponent<RandomFunction> ().enabled = true;
	}
}