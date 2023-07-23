using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
/*
public class TargetHealth : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    private void TargetDestroy()
    {
        //  Destroy(gameObject);
        this.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Hit");
            currentHealth -= collision.gameObject.GetComponent<HandleProjectile1>().damage;
            if (currentHealth <= 0)
            {
                Destroy(collision.gameObject);
                TargetDestroy();


            }
        }
    }
}
*/