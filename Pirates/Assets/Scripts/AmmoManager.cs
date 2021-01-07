using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour
{
    public static int ammoNumber;
    public static int ammoNumberP1;
    public static int ammoNumberP2;
    public Sprite zero, one, two, three, four, five, six, seven, eight, nine, ten;
    public Image thisSprite;


    void Update()
    {
        AmmoAdd();

    }


    void AmmoAdd() //Checks which player and then adds to their ammo count
    {
        if (gameObject.name == "AmmoNumberP1")
        {
            ammoNumber = ammoNumberP1;
        }
        else if (gameObject.name == "AmmoNumberP2")
        {
            ammoNumber = ammoNumberP2;
        }
        switch (ammoNumber)
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
            case 4:
                thisSprite.sprite = four;
                break;
            case 5:
                thisSprite.sprite = five;
                break;
            case 6:
                thisSprite.sprite = six;
                break;
            case 7:
                thisSprite.sprite = seven;
                break;
            case 8:
                thisSprite.sprite = eight;
                break;
            case 9:
                thisSprite.sprite = nine;
                break;
            case 10:
                thisSprite.sprite = ten;
                break;
            default:
                break;
        }
        ammoNumber = 0;
    }

}
