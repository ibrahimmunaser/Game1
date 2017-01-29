using UnityEngine;
using System.Collections;

public class Audio3 : MonoBehaviour {

	public AudioClip fireworks;
	private AudioSource source;

	public ParticleSystem green;
	public ParticleSystem yellow;
	public ParticleSystem blue;
	public ParticleSystem red;
	public ParticleSystem purple;
	public ParticleSystem orange;


	void OnEnable()
	{

			source = GetComponent<AudioSource> ();
			source.PlayOneShot (fireworks, 0.5F);

			green.Play();
			blue.Play();
			purple.Play();
			red.Play();
			orange.Play();
			yellow.Play();
	}
}
