using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rigid;

    public bool isMove = false;
    public bool isGrounded = false;
    public bool isFacingRight = true;
    public bool isRight = false;
    public bool isLeft = false;
    public float jumpForce = 200f;
    public float walkForce = 15f;
    public float maxSpeed = 1.5f;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isMove = false;
        InputHandler();
        if (isMove)
        {
            anim.SetInteger("Speed", 1);
        }
        else
        {
            anim.SetInteger("Speed", 0);
        }
    }

    void InputHandler()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || isLeft)
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow) || isRight)
        {
            MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            Jump();
        }
    }

    public void GoRight()
    {
        isRight = true;
    }

    public void StopRight()
    {
        isRight = false;
    }

    public void GoLeft()
    {
        isLeft = true;
    }

    public void StopLeft()
    {
        isLeft = false;
    }

    void MoveLeft()
    {
        isMove = true;
        if (rigid.velocity.x * -1 < maxSpeed)
            rigid.AddForce(Vector2.left * walkForce);

        if (isFacingRight)
        {
            Flip();
        }
    }

    void MoveRight()
    {
        isMove = true;
        if (rigid.velocity.x * 1 < maxSpeed)
            rigid.AddForce(Vector2.right * walkForce);

        if (!isFacingRight)
        {
            Flip();
        }
    }

    void Jump()
    {
        if (isGrounded == true)
        {
            rigid.AddForce(Vector2.up * jumpForce);
        }
        
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        isFacingRight = !isFacingRight;
    }

    public void DoJump()
    {
        Jump();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("IsGrounded", true);
            isGrounded = true;
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("IsGrounded", true);
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("IsGrounded", false);
            isGrounded = false;
        }
    }
}