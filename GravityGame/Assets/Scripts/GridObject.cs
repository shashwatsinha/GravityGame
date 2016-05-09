using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class GridObject : MonoBehaviour {

    public int xCoord = 0;
    public int yCoord = 0;

    public int width = 1;
    public int height = 1;

    public bool atRest;

	// Use this for initialization
    void Start()
    {
        transform.position = new Vector2((float)xCoord - 10.0f + (float)width / 2, (float)yCoord - 5.0f + (float)height / 2);
        transform.localScale = new Vector2(width, height);

        atRest = true;

    }
	
	// Update is called once per frame
	void Update () {
	}

    public bool IsGridCoordinatesPartOfObject(int xCoord, int yCoord)
    {
        if ( this.xCoord <= xCoord && xCoord < this.xCoord + this.width)
        {
            if (this.yCoord <= yCoord && yCoord < this.yCoord + this.height)
            {
                return true;
            }
        }

        return false;
    }

}
