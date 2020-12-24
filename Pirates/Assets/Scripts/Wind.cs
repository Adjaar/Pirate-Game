using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public string currentWind;
    private void Start()
    {
        StartCoroutine(CurrentWind());
    }

    IEnumerator CurrentWind()
    {
        while (true)
        {
            int wind = Random.Range(1, 5);//Every time Wind is called it will be assigned a random number from 1-4. North(1) East(2) South(3) West(4). Goes to 5 because the range excludes the top number when dealing with integers
           
            switch (wind)
            {
                case 1:
                    currentWind = "N";
                    break;
                case 2:
                    currentWind = "E";
                    break;
                case 3:
                    currentWind = "S";
                    break;
                case 4:
                    currentWind = "W";
                    break;
                default:
                    break;

            }
            yield return new WaitForSeconds(30f);
            
        }

    }
}
