using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour
{
   
    public Rigidbody2D rotation;
    public GameObject compass;
    private Wind windDirection;
    // Start is called before the first frame update
    void Start()
    {
        windDirection = compass.GetComponent<Wind>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (windDirection.currentWind)
        {
            case "N":
                rotation.rotation = 0;
                break;
            case "E":
                rotation.rotation = -90;
                break;
            case "S":
                rotation.rotation = 180;
                break;
            case "W":
                rotation.rotation = 90;
                break;
            default:
                break;
        }
    }
}
