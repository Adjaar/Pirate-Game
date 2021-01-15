using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* CREW BENEFITS
 * 0/10 Sail around and fire 1 cannon ball with slow reload
 * 1/10 Normal reload
 * 2/7 Speed increase
 * 3/7 Two cannonballs
 * 4/7 Speed increase
 * 5/7 Three cannonballs 
 * 6/7 Higher defence
 * 7/7 Ship slowly repairs
 */

public class CrewManager : MonoBehaviour
{
    public static int crewNumber;
    public static int crewNumberP1;
    public static int crewNumberP2;
    public int gunNumber = 1;
    public Sprite zero, one, two, three, four, five, six, seven;
    public Image thisSprite;

    public Cannon coolDown;
    public PlayerMovement speed; //accesses speed modifier variable from PlayerMovement
    public PlayerHealth modifyHealthScript; //used to access and modify variables from PlayerHealth script

    private void Start()
    {
        crewNumberP1 = 2;
        crewNumberP2 = 2;
    }

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
            default:
                break;
        }

        if (crewNumberP1 <= 0)
        {
            crewNumberP1 = 0;
        }
        if (crewNumberP2 <= 0)
        {
            crewNumberP2 = 0;
        }
    }

    void CrewBenefits()
    {
        switch (crewNumber)
        {
           
            case 0:
                coolDown.cooldown = 2; //no crew resets the cooldown to a default number
                speed.speedModifier = 0f;
                gunNumber = 1;
                modifyHealthScript.fullCrew = false;
                modifyHealthScript.cannonDamage = 20;
                break;
            case 1:
                coolDown.cooldown = 1; //slightly faster reload on guns   
                speed.speedModifier = 0f;
                gunNumber = 1;
                modifyHealthScript.fullCrew = false;
                modifyHealthScript.cannonDamage = 20;
                break;
            case 2:
                speed.speedModifier = 5f; //a speed boost that ignores wind
                gunNumber = 1;
                modifyHealthScript.fullCrew = false;
                modifyHealthScript.cannonDamage = 20;
                break;
            case 3:
                speed.speedModifier = 5f;
                gunNumber = 2; //allows second cannon shot out of one action
                modifyHealthScript.fullCrew = false;
                modifyHealthScript.cannonDamage = 20;
                break;
            case 4:
                gunNumber = 2;
                speed.speedModifier = 8f; //fastest speed
                modifyHealthScript.fullCrew = false;
                modifyHealthScript.cannonDamage = 20;
                break;
            case 5:
                gunNumber = 3; //allows third cannon shot out of one action
                modifyHealthScript.fullCrew = false;
                modifyHealthScript.cannonDamage = 20;
                break;
            case 6:
                modifyHealthScript.cannonDamage = 10; //cannons do less damage
                modifyHealthScript.fullCrew = false;
                break;
            case 7:
                modifyHealthScript.fullCrew = true; //ship repairs over time
                break;
            default:
                break;
        }
    }
}
