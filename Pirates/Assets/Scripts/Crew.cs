using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crew : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            CrewManager.crewNumberP1 += 1;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player2")
        {
            CrewManager.crewNumberP2 += 1;
            Destroy(gameObject);
        }
    }
}
