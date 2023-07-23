using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    //(SerializedField) private LayerMask jumpableGround;

    private float dirX = 0f;
    public float moveSpeed = 7f;
    public float jumpForce = 14f;
    bool canJump = true;
    bool hit = false;
    private enum MovementState { Idle, Run_Animation, jump_Animation, fall }

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Start is called before the first frame update
        //void Start()
        {
            gameObject.CompareTag("Projectile");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            //if (collision.GetComponent<Fireball>() != null)
            {
                hit = true;
            }

            Destroy(collision.gameObject);
            //Projectile++;
        }
    }
    // Update is called once per frame
    /*void Update()
    {
        if (inputs.fire)
        {
            GameObject temp = Instantiate(fireBall, spawnTransform.position, spawnTransform.rotation);
            temp.GetComponent<Rigidbody>().AddForce(temp.transform.forward * force);
            inputs.fire = false;
        }
    }*/

}