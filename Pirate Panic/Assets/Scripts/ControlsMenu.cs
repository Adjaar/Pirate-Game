using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
   public GameObject menu, keyboard, controller;

    //Controls Menu
    public void Controls()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        menu.SetActive(false);
        this.gameObject.SetActive(true);
    }

    //Forward Button
    public void Forward()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        if (keyboard == isActiveAndEnabled)
        {
            Controlscon();
        }
    }

    //Back Button
    public void Back()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        if (controller == isActiveAndEnabled)
        {
            Controlskey();
        }
    }

    //Return to Main Menu Button
    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        menu.SetActive(true);
        this.gameObject.SetActive(false);
    }

    //Displays keyboard controls
    public void Controlskey()
    {
        keyboard.SetActive(true);
        controller.SetActive(false);
    }
    
    //Displays Gamepad controls
    public void Controlscon()
    {
        keyboard.SetActive(false);
        controller.SetActive(true);
    }


}
