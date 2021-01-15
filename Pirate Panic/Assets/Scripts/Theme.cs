using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Theme : MonoBehaviour
{

    public static GameObject instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this.gameObject;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Two Players")
        {
            DontDestroyOnLoad(gameObject);
        }
        else if (scene.name == "Main Menu")
        {
            Destroy(gameObject);
        }
    }



 
}
