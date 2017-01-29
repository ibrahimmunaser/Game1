using UnityEngine;
using System.Collections;
using System.Threading;

public class AUDIO : MonoBehaviour {
	public AudioClip rightAnswer;
	private AudioSource source;


	void OnEnable()
	{
		source = GetComponent<AudioSource> ();
		source.PlayOneShot (rightAnswer, 0.5F);
	}

			
}