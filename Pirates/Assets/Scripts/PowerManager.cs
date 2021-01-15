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
    //these get the info from the opposite player
   public PlayerHealth Damage;
   public PlayerMovement speedDamage;
    //this is for the active player
    private PlayerHealth shields;
    private PlayerMovement speedBoost;
   

    //determines what method to use
    private int usepower;
    //ammo has different ranges. Grapeshot is short, Chainshot is medium, regular is long
    private float rangeOfAmmo;
    private float timer;

    private void Awake()
    {
        controls = new InputMaster();
    }
    private void Start()
    {
        thisSprite = this.gameObject.GetComponent<Image>();
        shields = player.GetComponent<PlayerHealth>();
        speedBoost = player.GetComponent<PlayerMovement>();

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
        //remove the shield and speed effects after a certain period of time
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            timer = 0;
            player.transform.GetChild(15).gameObject.SetActive(false);
            speedBoost.speedPowerup = 0;
            shields.forceField = false;
            hasPower = false;
            RemovePower();
        }
    }

    public void CurrentPower(string power)
    {
        if (hasPower == false)
        {
            switch (power)
            {
                case "Chainshot":
                    thisSprite.sprite = chainshotBox;
                    usepower = 1;
                    break;
                case "Grapeshot":
                    thisSprite.sprite = grapeshot;
                    usepower = 2;
                    break;
                case "Shield":
                    thisSprite.sprite = shield;
                    usepower = 3;
                    break;
                case "Speed":
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
        //timer for the shields
        timer = 10;

        player.transform.GetChild(15).gameObject.SetActive(true);
        shields.forceField = true;
    }
    void Speed()
    {
        timer = 5;

        speedBoost.speedPowerup = 12;
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
