using UnityEngine;
using System.Collections;

public class AUDIO2 : MonoBehaviour {

	public AudioClip wrongAnswer;
	private AudioSource source;
	
	
	
	public GameObject GreenTrig;
	public GameObject YellowTrig;
	public GameObject RedTrig;
	public GameObject BlueTrig;
	public GameObject PurpleTrig;
	public GameObject OrangeTrig;
	
	void OnEnable()
	{
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (wrongAnswer, 0.5F);
		
	}
}
