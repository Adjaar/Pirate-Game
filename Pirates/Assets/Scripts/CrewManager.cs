using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrewManager : MonoBehaviour
{
    public static int crewNumber;
    public static int crewNumberP1;
    public static int crewNumberP2;
    public Sprite zero, one, two, three, four, five, six, seven, eight, nine, ten;
    public Image thisSprite;
    
    void Update()
    {
        CrewAdd();
       
    }



    void CrewAdd() //Checks which player and then adds to their crew count
    {
        if (gameObject.name == "CrewNumberP1")
        {
            crewNumber = crewNumberP1;
        }
        else if (gameObject.name == "CrewNumberP2")
        {
            crewNumber = crewNumberP2;
        }
        switch (crewNumber)
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
    }
}
