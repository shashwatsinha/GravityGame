using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

    public static float upBoundary;
    public static float downBoundary;
    public static float leftBoundary;
    public static float rightBoundary;

	// Use this for initialization
	void Start () 
    {
        Vector3 wrld = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0.0f));
        upBoundary = wrld.y;
        wrld = Camera.main.ScreenToWorldPoint(new Vector3(-Screen.width, 0.0f, 0.0f));
        downBoundary = wrld.y;
        leftBoundary = wrld.x;
        wrld = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, 0.0f));
        rightBoundary = wrld.x;
	}
	

}
