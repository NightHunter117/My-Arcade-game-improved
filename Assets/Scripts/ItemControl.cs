using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    private int PowerUps = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUps"))
        {
            if (collision.GetComponent<Cherries>() != null)
            {
                // Do Cherry Stuff
            }

            Destroy(collision.gameObject);
            PowerUps++;
        }
    }
}