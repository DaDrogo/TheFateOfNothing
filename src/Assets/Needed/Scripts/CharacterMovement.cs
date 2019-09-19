using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterValues values;
    Rigidbody2D rb;

    float direction;

    public bool grounded = true;

    private void Start()
    {
        values = GetComponent<CharacterValues>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(float horMove, bool jump)
    {
        direction = horMove;
        Vector2 position = new Vector2(horMove, 0);
        //float posX = transform.position.x;
        //posX += horMove * Time.deltaTime * values.MoveSpeed;
        //transform.position = new Vector3(posX, transform.position.y, 0);
        if (Input.GetAxis("Horizontal") < 0)
        {
            Turn(-0.2f);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Turn(0.2f);
        }

        if (jump == true && grounded == true)
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(direction * values.MoveSpeed * Time.deltaTime, 0, 0));

    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * values.JumpHight,ForceMode2D.Impulse);
        grounded = false;
    }

    private void Turn(float xValue)
    {
        transform.localScale = new Vector3(xValue, 0.2f, 1);
    }
}
