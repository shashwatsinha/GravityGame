using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {

	void OnGUI()
    {
        if((GUI.Button(new Rect(Screen.width/2,100, 100, 50), "Reset")))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
