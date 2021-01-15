using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    string power;
    GameObject player;

    private void Start()
    {
        power = this.gameObject.tag;
        StartCoroutine(Despawn());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player1":
                player = GameObject.Find("HUD P1/Powerups/Power");               
                break;
            case "Player2":
                player = GameObject.Find("HUD P2/Powerups/Power");
                break;
            default:
                break;
        }

        FindObjectOfType<AudioManager>().Play("Powerup");
        if (player != null)
        {

            if (player.GetComponent<PowerManager>().hasPower == false)
            {
                Destroy(gameObject);
            }
            player.GetComponent<PowerManager>().CurrentPower(power);
        }

    }

    IEnumerator Despawn()
    {
        yield return new WaitForSeconds(60);
        Destroy(gameObject);
    }
}
