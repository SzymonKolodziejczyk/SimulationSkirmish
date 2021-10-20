using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public int health = 3;
    public int damage = 1;
    public int currentHealth;

    void Start()
    {
        currentHealth = health;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Agent"))
        {
            currentHealth -= damage;
        }
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
