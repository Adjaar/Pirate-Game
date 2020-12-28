using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* CREW BENEFITS
 * 0/10 Sail around and fire 1 cannon ball with slow reload
 * 1/10 Normal reload
 * 2/10 Speed increase
 * 3/10 Increased vision (if applicable)
 * 4/10 Two cannonballs
 * 5/10 More health from pickups
 * 6/10 Can board ships
 * 7/10 Speed increase
 * 8/10 Three cannonballs
 * 9/10 Higher defence
 * 10/10 Ship slowly repairs
 */

public class CrewManager : MonoBehaviour
{
    public static int crewNumber;
    public static int crewNumberP1;
    public static int crewNumberP2;
    public int gunNumber = 1;
    public Sprite zero, one, two, three, four, five, six, seven, eight, nine, ten;
    public Image thisSprite;

    public Cannon coolDown;
    public PlayerMovement speed;
    
    void Update()
    {
        CrewAdd();
        CrewBenefits();
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

    void CrewBenefits()
    {
        switch (crewNumber)
        {

            case 0:
                coolDown.cooldown = 3; //no crew resets the cooldown to a default number
                gunNumber = 1;
                break;
            case 1:
                coolDown.cooldown = 2; //slightly faster reload on guns      
                gunNumber = 1;
                break;
            case 2:
                speed.speedModifier = 5f; //a speed boost that ignores wind
                gunNumber = 1;
                break;
            case 3:
                //currently nothing
                gunNumber = 1;
                break;
            case 4:
                gunNumber = 2; //allows second cannon shot out of one action
                
                break;
            case 5:
                gunNumber = 2;
                break;
            case 6:
                gunNumber = 2;
                break;
            case 7:
                gunNumber = 3;
                break;
            case 8:
                
                break;
            case 9:
                
                break;
            case 10:
                
                break;
            default:
                break;
        }
    }
}
