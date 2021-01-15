using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    InputMaster controls;

    void Awake()
    {
        controls = new InputMaster();
    }

    private void Start()
    {
        controls.Player.Escape.performed += ctx => PauseMenu();
        controls.Player2.Escape.performed += ctx => PauseMenu();
    }

    // Update is called once per frame
    void PauseMenu()
    {
        pause.SetActive(true);
        Time.timeScale = 0;

    }

   public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
