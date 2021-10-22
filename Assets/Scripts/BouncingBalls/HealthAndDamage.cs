using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndDamage : MonoBehaviour
{
    public int health = 3;
    public int currentHealth;
    public int damage = 1;
    public Text healthInformation;
    public Text AgentName;

    void Start()
    {
        currentHealth = health;
    }

    void Update()
    {
        healthInformation.text = "" + currentHealth + " / " + health;
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
