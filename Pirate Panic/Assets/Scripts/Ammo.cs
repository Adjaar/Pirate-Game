using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<AudioManager>().Play("Ammo");
        if (collision.gameObject.tag == "Player1" && AmmoManager.ammoNumberP1 != 10)
        {          
            AmmoManager.ammoNumberP1 += 1;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player2" && AmmoManager.ammoNumberP2 != 10)
        {
            AmmoManager.ammoNumberP2 += 1;
            Destroy(gameObject);
        }
    }
}
