using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamDamage : MonoBehaviour
{
    private PlayerHealth enemyPlayerHealth;
    private PlayerMovement thisPlayerDamage;
    private Animator crash;
    private bool touched = false;

    private void Start()
    {
        thisPlayerDamage = this.gameObject.GetComponentInParent<PlayerMovement>();
        crash = this.gameObject.GetComponentInChildren<Animator>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.GetComponent<Collider2D>().name == "Vulnerable" && touched == false)
        {            
            enemyPlayerHealth = collision.gameObject.GetComponentInParent<PlayerHealth>();
            enemyPlayerHealth.TakeDamage(thisPlayerDamage.damageModifier);
            thisPlayerDamage.damageModifier = 0;

            FindObjectOfType<AudioManager>().Play("Ram");
            crash.SetTrigger("Crashed");
            touched = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touched = false;
    }
}
