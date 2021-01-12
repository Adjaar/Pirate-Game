using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerManager : MonoBehaviour
{
    //prevents player from changing powerup if they already have one
    public bool hasPower; 
    [SerializeField]
    private Sprite chainshotBox, grapeshot, shield, speed;

    public Image thisSprite;
    public GameObject player;
    public InputMaster controls;

    //chainshot and grapeshot do less than regular cannons and also harm things other than health like speed and crew numbers
   public PlayerHealth Damage;
   public PlayerMovement speedDamage;
   public CrewManager crewDamage;

    //determines what method to use
    private int usepower;
    //ammo has different ranges. Grapeshot is short, Chainshot is medium, regular is long
    private float rangeOfAmmo;

    private void Awake()
    {
        controls = new InputMaster();
    }
    private void Start()
    {
        thisSprite = this.gameObject.GetComponent<Image>();

        switch (player.name)
        {
            case "Player1":
                controls.Player.Powerup.performed += ctx => SetPower();
                break;
            case "Player2":
                controls.Player2.Powerup.performed += ctx => SetPower();
                break;
            default:
                break;
        }


    }
    private void Update()
    {
    }
    public void CurrentPower(string power)
    {

        if (hasPower == false)
        {
            switch (power)
            {
                case "ChainshotBox":
                    thisSprite.sprite = chainshotBox;
                    usepower = 1;
                    break;
                case "Grapeshot":
                    thisSprite.sprite = grapeshot;
                    usepower = 2;
                    break;
                case "Shield Powerup":
                    thisSprite.sprite = shield;
                    usepower = 3;
                    break;
                case "Speed Powerup":
                    thisSprite.sprite = speed;
                    usepower = 4;
                    break;
                default:
                    break;
            }
            this.gameObject.SetActive(true);
            hasPower = true;
        }
            
    }

    void RemovePower()
    {
        this.gameObject.SetActive(false); //an empty sprite is a white square so this is to simulate empty sprite

       
        usepower = 0;
    }
    void SetPower()
    {
        //calls method based on current powerup
        switch (usepower)
        {
            case 1: 
                Chainshot();
                break;
            case 2:
                Grapeshot();
                break;
            case 3:
                Shield();
                break;
            case 4:
                Speed();
                break;
            default:
                break;
        }
    }
    void Chainshot()
    {
        Damage.penalty = 10;
        speedDamage.speedPenalty = 10;
        rangeOfAmmo = 0.5f;
        player.GetComponent<Cannon>().FirePowerups(player.transform.GetChild(1).position, player.transform.GetChild(7).position, player.transform.GetChild(5).position, player.transform.GetChild(11).position, rangeOfAmmo, 1);
        player.GetComponent<Cannon>().FirePowerups(player.transform.GetChild(0).position, player.transform.GetChild(6).position, player.transform.GetChild(4).position, player.transform.GetChild(9).position, rangeOfAmmo, 1);

        hasPower = false;
        RemovePower();
    }
    void Grapeshot()
    {
        Damage.penalty = 5;
        int crewDeaths = Random.Range(1, 4);
        Damage.crewLoss = crewDeaths;
        
        rangeOfAmmo = 0.25f;
        player.GetComponent<Cannon>().FirePowerups(player.transform.GetChild(1).position, player.transform.GetChild(7).position, player.transform.GetChild(5).position, player.transform.GetChild(11).position, rangeOfAmmo, 2);
        player.GetComponent<Cannon>().FirePowerups(player.transform.GetChild(0).position, player.transform.GetChild(6).position, player.transform.GetChild(4).position, player.transform.GetChild(9).position, rangeOfAmmo, 2);

        hasPower = false;
        RemovePower();
    }
    void Shield()
    {

    }
    void Speed()
    {

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
