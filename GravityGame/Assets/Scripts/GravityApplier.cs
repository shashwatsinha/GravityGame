using UnityEngine;
using System.Collections;

public class GravityApplier : MonoBehaviour {


	// Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0.0f;
    }

    void FixedUpdate()
    {

        switch (GravityManager.gravityDirection)
        {
            case GravityDirection.DOWN:
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -GravityManager.gravityStrength));
                break;
            case GravityDirection.UP:
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, GravityManager.gravityStrength));
                break;
            case GravityDirection.RIGHT:
                GetComponent<Rigidbody2D>().AddForce(new Vector2(GravityManager.gravityStrength, 0));
                break;
            case GravityDirection.LEFT:
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-GravityManager.gravityStrength, 0));
                break;
        }
	}

  
}
