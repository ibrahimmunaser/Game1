using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scorecount : MonoBehaviour {

	public static int count;
	public Text countText;
	// Use this for initialization
	void Start()
	{
		count=0;
		Display ();
	}

	public void Display () {
		countText.text=count.ToString();
	}

}
