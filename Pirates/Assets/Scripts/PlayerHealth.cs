using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int cannonDamage = 20;

    public bool fullCrew;
    

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        StartCoroutine(ShipRepair());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cannonball")
        {
            TakeDamage(cannonDamage);
           
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        

    healthBar.SetHealth(currentHealth);
    }

    IEnumerator ShipRepair() //ship slowly repairs with full crew
    {
        while (true)
        {
            if (fullCrew == true && currentHealth < maxHealth)
            {
                currentHealth += 2;

                healthBar.SetHealth(currentHealth);
        

            }
            yield return new WaitForSeconds(5f);
        }

    }
}
