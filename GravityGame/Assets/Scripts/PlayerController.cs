using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    public float jumpSpeed = 5.0f;
    private bool grounded;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        grounded = true;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (grounded)
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            else
                transform.Translate(new Vector3(speed / 10 * Time.deltaTime, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (grounded)
                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            else
                transform.Translate(new Vector3(-speed / 10 * Time.deltaTime, 0, 0));
        }

        if ((Input.GetKeyDown(KeyCode.W)) && grounded == true)
        {
            rb2d.velocity = new Vector2(0f, jumpSpeed);
            grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "GridObject")
        {
            grounded = true;
        }
    }
}
