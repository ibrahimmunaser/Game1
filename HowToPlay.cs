using UnityEngine;
using System.Collections;

public class HowToPlay:MonoBehaviour
{
    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Application.LoadLevel("Menu2");
        }
    }

}