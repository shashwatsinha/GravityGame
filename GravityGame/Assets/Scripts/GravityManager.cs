using UnityEngine;
using System.Collections;

public enum GravityDirection
{
    UP, DOWN, LEFT, RIGHT
}

public class GravityManager : MonoBehaviour
{
    public int gravityValue;
    public static GravityDirection gravityDirection;
    private bool gravityChangeable;
    public static float gravityStrength = 5;
    GameObject[] gos;
    // Use this for initialization
    void Start()
    {
        gos = GameObject.FindGameObjectsWithTag("GridObject");

        gravityChangeable = true;
        switch (gravityValue)
        {
            case 1:
                gravityDirection = GravityDirection.UP;
                break;

            case 2:
                gravityDirection = GravityDirection.DOWN;
                break;

            case 3:
                gravityDirection = GravityDirection.LEFT;
                break;

            case 4:
                gravityDirection = GravityDirection.RIGHT;
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {

        gravityChangeable = GridManager.AtRest();
        if (Input.GetKeyDown(KeyCode.UpArrow) && gravityChangeable == true)
        {    
            gravityDirection = GravityDirection.UP;
            gravityChangeable = false;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && gravityChangeable == true)
        {
            gravityDirection = GravityDirection.DOWN;
            gravityChangeable = false;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && gravityChangeable == true)
        {
            gravityDirection = GravityDirection.RIGHT;
            gravityChangeable = false;

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && gravityChangeable == true)
        {
            gravityDirection = GravityDirection.LEFT;
            gravityChangeable = false;

        }


        // CheckMotion();
    }

    void OnSwipeUp()
    {
        gravityDirection = GravityDirection.UP;

    }

    void OnSwipeDown()
    {
        gravityDirection = GravityDirection.DOWN;

    }

    void OnSwipeLeft()
    {
        gravityDirection = GravityDirection.LEFT;

    }

    void OnSwipeRight()
    {
        gravityDirection = GravityDirection.RIGHT;

    }

    void CheckMotion()
    {
        /*   int flag = 0;
           for(int i=0;i<gos.Length;i++)
           {
               Vector3 curPos = gos[i].transform.position;

               if (gos[i].GetComponent<Rigidbody2D>().velocity != Vector2.zero)
               {
                   flag = 1; 
              
               }
           }

           if (flag == 0)
               gravityChangeable = true;
           else
               gravityChangeable = false;
        }
    
      */
    }
}
