using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port : MonoBehaviour
{

    public GameObject p1, p2;
    public static bool pressed; //checks if player interacted while still in trigger

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement.interaction = ("Port" + collision.name);

        switch (collision.name)
        {
            case "Player1":
                p1.SetActive(true);
                break;
            case "Player2":
                p2.SetActive(true);
                break;
            default:
                break;
        }

        if (pressed == true)
        {
            p1.SetActive(false);
            p2.SetActive(false);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.name)
        {
            case "Player1":
                p1.SetActive(false);
                break;
            case "Player2":
                p2.SetActive(false);
                break;
            default:
                break;
        }
        pressed = false;
    }

}
