using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TIMER : MonoBehaviour {

	public float timeLeft = 30.0f;
	public Text timerCount;
	void Update()
	{
		timeLeft -= Time.deltaTime;
		timerCount.text = timeLeft.ToString("#.##");
	}
}
