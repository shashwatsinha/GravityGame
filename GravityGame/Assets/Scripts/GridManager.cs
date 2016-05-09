using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

    public static GridObject[] gridObjects;

	// Use this for initialization
	void Start () {
        gridObjects = GameObject.FindObjectsOfType<GridObject>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static bool AtRest()
    {
        foreach (GridObject gridObject in gridObjects)
        {
            if (gridObject.atRest == false)
            {
                return false;
            }
        }
        return true;
    }

   public static bool IsGridSpaceEmpty(int xCoord, int yCoord)
    {
       if(xCoord < 0 || 19 < xCoord || yCoord < 0 || 9 < yCoord)
       {
           return false;
       }

        foreach(GridObject gridObject in gridObjects)
        {
            if (gridObject.IsGridCoordinatesPartOfObject(xCoord, yCoord))
            {
                return false;
            }
        }

        return true;
    }

   public static bool IsGridSpaceEmpty(int xCoord, int yCoord, GridObject _gridObject)
   {
       if (xCoord < 0 || 19 < xCoord || yCoord < 0 || 9 < yCoord)
       {
           return false;
       }

       foreach (GridObject gridObject in gridObjects)
       {
           if (gridObject != _gridObject && gridObject.IsGridCoordinatesPartOfObject(xCoord, yCoord))
           {
               return false;
           }
       }

       return true;
   }
}
