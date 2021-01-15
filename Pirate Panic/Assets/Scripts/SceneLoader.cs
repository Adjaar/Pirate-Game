using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void Play()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }

    public void TwoPlayer()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Time.timeScale = 1;
        SceneManager.LoadScene("Two Players", LoadSceneMode.Single);
    }
    public void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }

}
