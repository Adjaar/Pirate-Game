using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int lives = 3;
    public int cannonDamage = 20;

    public bool fullCrew;

    public GameOver endGame;
    public Respawn spawner;
    public HealthBar healthBar;

    public Animator health;

    private string p_Name;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        StartCoroutine(ShipRepair());
        p_Name = this.gameObject.name;
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
        CrewLoss();

    healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Death();
        }

        health.SetTrigger("Damaged");
    }

    void Death()
    {
        lives--;
        if (lives < 0)
        {
            endGame.EndGame(p_Name);
        }
        else
        {
            currentHealth = maxHealth;

            spawner.Spawn(this.gameObject.transform);
            healthBar.SetHealth(currentHealth);
        }
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

    void CrewLoss()
    {
        int probability;
        probability = Random.Range(1, 11);
        if (p_Name == "Player1" && probability == 1)
        {
            CrewManager.crewNumberP1 -= 1;
        }
        if (p_Name == "Player2" && probability == 1)
        {
            CrewManager.crewNumberP2 -= 1;
        }
    }
}
