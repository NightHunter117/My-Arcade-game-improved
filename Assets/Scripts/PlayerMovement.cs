using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    //(SerializedField) private LayerMask jumpableGround;

    private float dirX = 0f;
    public float moveSpeed = 7f;
    public float jumpForce = 14f;
    bool canJump = true;

    private enum MovementState { Idle, Run_Animation, jump_Animation, fall }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        //coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //left/right movement
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //jumping
        if (Input.GetButtonDown("Jump") && canJump)
        {
            canJump = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();

    }

    //Animation
    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.Run_Animation;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.Run_Animation;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.Idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jump_Animation;
        }

        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.fall;
        }

        anim.SetInteger("state", (int)state);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //return Physics2D.Boxcast(coll.bonds.center, coll.bounds.size, 0f, Vector2.down, 1f, jumpableGround)
            canJump = true;
        }
    }
}
