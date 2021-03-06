﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crew : MonoBehaviour
{
    public Sprite[] pickSprite;
    private SpriteRenderer thisSprite;

    private void Start()
    {
        pickSprite = Resources.LoadAll<Sprite>("Crew Art");
        int crew = Random.Range(0, 6);
        thisSprite = this.gameObject.GetComponent<SpriteRenderer>();
        thisSprite.sprite = pickSprite[crew];

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player1" && CrewManager.crewNumberP1 != 7)
        {
            CrewManager.crewNumberP1 += 1;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player2" && CrewManager.crewNumberP2 != 7)
        {
            CrewManager.crewNumberP2 += 1;
            Destroy(gameObject);
        }
    }
}
