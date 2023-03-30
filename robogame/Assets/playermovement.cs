using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MovementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")) {
            rb.AddForce(new Vector2(MovementSpeed / 100, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey("w")) {
            rb.AddForce(new Vector2(0, MovementSpeed / 100), ForceMode2D.Impulse);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(new Vector2(-MovementSpeed / 100, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey("s")) {
            rb.AddForce(new Vector2(0, -MovementSpeed / 100), ForceMode2D.Impulse);
        }
    }
}
