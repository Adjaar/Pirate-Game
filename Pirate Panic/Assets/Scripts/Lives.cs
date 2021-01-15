using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public PlayerHealth numberOfLives;
    public Sprite zero, one, two, three;
    public Image thisSprite;

    private void Update()
    {

        switch (numberOfLives.lives)
        {

            case 0:
                thisSprite.sprite = zero;
                break;
            case 1:
                thisSprite.sprite = one;
                break;
            case 2:
                thisSprite.sprite = two;
                break;
            case 3:
                thisSprite.sprite = three;
                break;
        }

    }
}
