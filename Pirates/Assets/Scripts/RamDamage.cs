using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamDamage : MonoBehaviour
{
    private PlayerHealth enemyPlayerHealth;
    private PlayerMovement thisPlayerDamage;
    private bool touched = false;

    private void Start()
    {
        thisPlayerDamage = this.gameObject.GetComponentInParent<PlayerMovement>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.collider.tag == "Vulnerable" && touched == false)
        {            
            enemyPlayerHealth = collision.gameObject.GetComponentInParent<PlayerHealth>();
            enemyPlayerHealth.TakeDamage(thisPlayerDamage.damageModifier);
            thisPlayerDamage.damageModifier = 0;
            touched = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        touched = false;
    }
}
