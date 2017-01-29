using UnityEngine;
using System.Collections;

public class Lights2 : MonoBehaviour {

	public float duration = 1.0F;
	public Light lt;
	void Start() {
		lt = GetComponent<Light>();
	}
	void OnEnable() {
		float phi = Time.time / duration * 2 * Mathf.PI;
		float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
		lt.intensity = amplitude;
	}
}
