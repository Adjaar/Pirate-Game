using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public int lives = 3;
    public float cannonDamage = 20;
    public float penalty = 0;
    public float crewBenefit = 1;

    public int crewLoss = 0;
    int probability;

    public bool fullCrew;
    public bool forceField;

    public GameOver endGame;
    public Respawn spawner;
    public HealthBar healthBar;
    public Animator health;

    public GameObject crewPrefab;

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
        if (collision.gameObject.tag == "Cannonball" && forceField == false)
        {
            FindObjectOfType<AudioManager>().Play("Ship hit");
            TakeDamage(cannonDamage);
        }
        
    }
   public void TakeDamage(float damage)
    {
        currentHealth -= damage - penalty / crewBenefit;
        CrewLoss();
        GrapeshotLoss(crewLoss);

        penalty = 0;

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
        probability = Random.Range(1, 11);
        if (p_Name == "Player1" && probability == 1)
        {
            CrewManager.crewNumberP1 -= 1;
        }
        if (p_Name == "Player2" && probability == 1)
        {
            CrewManager.crewNumberP2 -= 1;
        }

        if (probability == 1)
        {
            Vector2 pos;
            pos = this.gameObject.transform.position + new Vector3(Random.Range(-1, 1), -2);
            int crewDrop = Random.Range(1, 3);
            if (crewDrop == 1)
                Instantiate(crewPrefab, pos, Quaternion.identity);
        }
    }
    void GrapeshotLoss(int loss)
    {
        if (p_Name == "Player1")
        {
            CrewManager.crewNumberP1 -= loss;
        }
        if (p_Name == "Player2")
        {
            CrewManager.crewNumberP2 -= loss;
        }
        crewLoss = 0;

        if (crewLoss != 0)
        {
            Vector2 pos;
            pos = this.gameObject.transform.position + new Vector3(Random.Range(-1, 1), -2);//(-1, -1);
            int crewDrop = Random.Range(1, 3);
            if (crewDrop == 1)
                Instantiate(crewPrefab, pos, Quaternion.identity);

        }
    }
}
