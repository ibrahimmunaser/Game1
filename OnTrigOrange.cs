using UnityEngine;
using System.Collections;

public class OnTrigOrange : MonoBehaviour {
	
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
	private int count1;
	float timeLeft = 3.0f;

	public GameObject script;
	
	
	void OnMouseDown() 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if(Green.activeSelf)
			{
				Yellow.GetComponent<EnvelopeOrange>().enabled=false;
				Red.GetComponent<EnvelopeOrange>() .enabled=false;
				Blue.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=false;
				Green.GetComponent<EnvelopeOrange> ().enabled = true;
			}
			else if(Yellow.activeSelf)
			{
				Green.GetComponent<EnvelopeOrange> ().enabled = false;
				Red.GetComponent<EnvelopeOrange>() .enabled=false;
				Blue.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=false;
				Yellow.GetComponent<EnvelopeOrange>() .enabled=true;
			}
			else if(Purple.activeSelf)
			{
				Yellow.GetComponent<EnvelopeOrange>() .enabled=false;
				Green.GetComponent<EnvelopeOrange> ().enabled = false;
				Red.GetComponent<EnvelopeOrange>() .enabled=false;
				Blue.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=true;
			}
			else if(Blue.activeSelf)
			{
				Yellow.GetComponent<EnvelopeOrange>() .enabled=false;
				Green.GetComponent<EnvelopeOrange> ().enabled = false;
				Red.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=false;
				Blue.GetComponent<EnvelopeOrange>() .enabled=true;
			}
			else if(Orange.activeSelf)
			{
				Yellow.GetComponent<EnvelopeOrange>() .enabled=false;
				Green.GetComponent<EnvelopeOrange> ().enabled = false;
				Red.GetComponent<EnvelopeOrange>() .enabled=false;
				Blue.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=true;
			}
			else if(Red.activeSelf)
			{
				Yellow.GetComponent<EnvelopeOrange>() .enabled=false;
				Green.GetComponent<EnvelopeOrange> ().enabled = false;
				Red.GetComponent<EnvelopeOrange>() .enabled=true;
				Blue.GetComponent<EnvelopeOrange>() .enabled=false;
				Orange.GetComponent<EnvelopeOrange>() .enabled=false;
				Purple.GetComponent<EnvelopeOrange>() .enabled=false;
			}
		}
	}
	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.tag == "Orange") 
		{
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

			OrangeTrig.GetComponent<AUDIO> ().enabled = true;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			OrangeTrig.GetComponent<AUDIO2>().enabled = false;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			Debug.Log("ORANGE SOUND ON");
			Orange.GetComponent<EnvelopeOrange> ().enabled = false;
			Orange.GetComponent<GoUpOrange> ().enabled = false;
			Orange.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Orange.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Yellow") {
			OrangeTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Yellow.GetComponent<EnvelopeOrange> ().enabled = false;
			Yellow.GetComponent<GoUpYellow> ().enabled = false;
			Yellow.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Yellow.transform.rotation = Quaternion.Euler(90,0,0);

		}
		else if(col.gameObject.tag == "Purple")
		{		
			OrangeTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Purple.GetComponent<EnvelopeOrange>().enabled=false;
			Purple.GetComponent<GoUpPurple> ().enabled = false;
			Purple.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Purple.transform.rotation = Quaternion.Euler(90,0,0);

		}
		else if (col.gameObject.tag == "Red") {
			OrangeTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;

			Red.GetComponent<EnvelopeOrange> ().enabled = false;
			Red.GetComponent<GoUpRed> ().enabled = false;
			Red.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Red.transform.rotation = Quaternion.Euler(90,0,0);

			
		}
		else if (col.gameObject.tag == "Green") 
		{
			OrangeTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;
			
			Green.GetComponent<EnvelopeOrange> ().enabled = false;
			Green.GetComponent<GoUpGreen> ().enabled = false;
			Green.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Green.transform.rotation = Quaternion.Euler(90,0,0);
		}
		else if (col.gameObject.tag == "Blue") {
			OrangeTrig.GetComponent<AUDIO2>().enabled = true;
			GreenTrig.GetComponent<AUDIO2> ().enabled = false;
			BlueTrig.GetComponent<AUDIO2> ().enabled = false;
			YellowTrig.GetComponent<AUDIO2> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO2> ().enabled = false;
			RedTrig.GetComponent<AUDIO2> ().enabled = false;

			OrangeTrig.GetComponent<AUDIO> ().enabled = false;
			GreenTrig.GetComponent<AUDIO> ().enabled = false;
			BlueTrig.GetComponent<AUDIO> ().enabled = false;
			YellowTrig.GetComponent<AUDIO> ().enabled = false;
			PurpleTrig.GetComponent<AUDIO> ().enabled = false;
			RedTrig.GetComponent<AUDIO> ().enabled = false;;

			Blue.GetComponent<EnvelopeOrange> ().enabled = false;
			Blue.GetComponent<GoUpBlue> ().enabled = false;
			Blue.transform.position = new Vector3 (-11.63f, -10.45f, 30.09f);
			Blue.transform.rotation = Quaternion.Euler(90,0,0);
			
		}
	
		randomize.SetActive (true);
		randomize.GetComponent<RandomFunction> ().enabled = true;
		
	}
}