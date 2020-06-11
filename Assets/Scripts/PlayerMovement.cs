using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    private float movementHorizontal;
    private float movementVertical;


    Quaternion targetUp = Quaternion.Euler(0, 0, 90);
    Quaternion targetDown = Quaternion.Euler(0, 0, -90);
    Quaternion targetBack = Quaternion.Euler(0, 0, 0);


    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        moveRightLeft();
        moveUpDown();
    }

    void moveRightLeft()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Slerp(transform.rotation, targetBack, 1);
        if (movementHorizontal > 0f)
        {
            sr.flipX = false;
            rb.velocity = new Vector2(movementHorizontal * speed, rb.velocity.y);
        }
        else if (movementHorizontal < 0f)
        {
            sr.flipX = true;
            rb.velocity = new Vector2(movementHorizontal * speed, rb.velocity.y);
        }
        rb.velocity = new Vector2(movementHorizontal * speed, rb.velocity.y);
    }



    void moveUpDown()
    {
        movementVertical = Input.GetAxis("Vertical");
        //
        if (movementVertical > 0f)
        {
            if(sr.flipX == true)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetDown, 1);
                rb.velocity = new Vector2(rb.velocity.x, movementVertical * speed);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetUp, 1);
                rb.velocity = new Vector2(rb.velocity.x, movementVertical * speed);
            }

        }
        else if (movementVertical < 0f)
        {
            if (sr.flipX == true)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetUp, 1);
                rb.velocity = new Vector2(rb.velocity.x, movementVertical * speed);
            }
            else
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetDown, 1);
                rb.velocity = new Vector2(rb.velocity.x, movementVertical * speed);
            }
        }
        rb.velocity = new Vector2(rb.velocity.x, movementVertical * speed);
    }
}
