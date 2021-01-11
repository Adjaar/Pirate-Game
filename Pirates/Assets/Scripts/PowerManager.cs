using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerManager : MonoBehaviour
{
    [SerializeField]
    private Sprite chainshotBox, grapeshot, shield, speed;
    public Image thisSprite;

    private void Start()
    {
        thisSprite = this.gameObject.GetComponent<Image>();
        currentPower("none");
    }
    private void Update()
    {

    }
    public void currentPower(string power)
    {

        this.gameObject.SetActive(true); 
        switch (power)
        {
            case "none":
                this.gameObject.SetActive(false); //an empty sprite is a white square so this is to simulate empty sprite
                break;
            case "ChainshotBox":
                thisSprite.sprite = chainshotBox;
                break;
            case "Grapeshot":
                thisSprite.sprite = grapeshot;
                break;
            case "Shield Powerup":
                thisSprite.sprite = shield;
                break;
            case "Speed Powerup":
                thisSprite.sprite = speed;
                break;
            default:
                break;
        }
            
    }
}
