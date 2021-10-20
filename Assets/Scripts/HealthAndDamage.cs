using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public int health = 1;
    public int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Agent"))
        {
            health -= damage;
            print(health);
        }
        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
}
