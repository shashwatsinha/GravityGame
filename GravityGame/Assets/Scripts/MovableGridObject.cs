using UnityEngine;
using System.Collections;

public class MovableGridObject : GridObject
{
    public static float transitionTime = .15f;
    public float timer = 0;

    void Update()
    {
        if (!atRest)
            timer += Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        switch (GravityManager.gravityDirection)
        {
            case GravityDirection.DOWN:
                Move(0, -1);
                break;
            case GravityDirection.UP:
                Move(0, 1);
                break;
            case GravityDirection.RIGHT:
                Move(1, 0);
                break;
            case GravityDirection.LEFT:
                Move(-1, 0);
                break;
        }


    }

    void Move(int xCoord, int yCoord)
    {
        Debug.Log("X: " + xCoord + "Y: " + yCoord);
        if (CanMove(xCoord, yCoord))
        {
            atRest = false;

            if (timer > transitionTime)
            {
                this.xCoord += xCoord;
                this.yCoord += yCoord;

                timer = 0;
            }
            else
            {
                Vector2 currentPosition = new Vector2(this.xCoord - 10 + (float)width / 2, this.yCoord - 5 + (float)height / 2);
                Vector2 nextPosition = new Vector2(this.xCoord + xCoord - 10 + (float)width / 2, this.yCoord + yCoord- 5 + (float)height / 2);
                transform.position = Vector2.Lerp(currentPosition, nextPosition, timer / transitionTime);
                Debug.Log(currentPosition);
                Debug.Log(nextPosition);
            }
        }
        else
        {
            atRest = true;
            transform.position = new Vector2(this.xCoord - 10 + (float)width / 2, this.yCoord - 5 + (float)height / 2);
        }
    }

    bool CanMove(int xCoord, int yCoord)
    {
        if(xCoord < 0)
        {
            for(int i =0; i < height; i++)
            {
                if (!GridManager.IsGridSpaceEmpty(this.xCoord + xCoord, this.yCoord + i, this))
                {
                    return false;
                }
            }
        }
        else if (xCoord > 0)
        {
            for (int i = 0; i < height; i++)
            {
                if (!GridManager.IsGridSpaceEmpty(this.xCoord + width + xCoord - 1, this.yCoord + i, this))
                {
                    return false;
                }
            }
        }
        
        if (yCoord < 0)
        {
            for (int i = 0; i < width; i++)
            {
                if (!GridManager.IsGridSpaceEmpty(this.xCoord + i, this.yCoord + yCoord, this))
                {
                    return false;
                }
            }
        }
        else if (yCoord > 0)
        {
            for (int i = 0; i < width; i++)
            {
                if (!GridManager.IsGridSpaceEmpty(this.xCoord + i, this.yCoord + yCoord + height - 1, this))
                {
                    return false;
                }
            }
        }


        return true;
    }
}
