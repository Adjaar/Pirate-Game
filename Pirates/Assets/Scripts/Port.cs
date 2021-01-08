using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port : MonoBehaviour
{

    public Animator p1, p2;
    public static bool pressed1, pressed2; //checks if player interacted while still in trigger

   string instance1, instance2 = null;  //seperating the events between both players so that they can't change each others ammo grabs

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (instance1 == null)
        {
            instance1 = (("Port") + collision.name);
        }
        else if (instance1 != null)
        {
            instance2 = (("Port") + collision.name);
        }
        PlayerMovement.interaction = (instance1);
        PlayerMovement.secondInteraction = (instance2);

        switch (collision.name)
        {
            case "Player1":
                p1.SetBool("inRange", true);
                break;
            case "Player2":
                p2.SetBool("inRange", true);
                break;
            default:
                break;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (pressed1 == true)
        {
            p1.SetTrigger("pressed");
            pressed1 = false;
        }
        if (pressed2 == true)
        {
            p2.SetTrigger("pressed");
            pressed2 = false;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.name)
        {
            case "Player1":
                p1.SetBool("inRange", false);
                break;
            case "Player2":
                p2.SetBool("inRange", false);
                break;
            default:
                break;
        }
        
        instance1 = null;
        instance2 = null;
    }

}
