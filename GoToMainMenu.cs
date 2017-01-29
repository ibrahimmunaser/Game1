using UnityEngine;
using System.Collections;

public class GoToMainMenu : MonoBehaviour
{
    void OnMouseDown()
    {
        if(Input.GetMouseButton(0))
        {
            Application.LoadLevel("MainMenu");
        }
    }
        
}