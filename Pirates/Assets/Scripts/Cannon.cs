using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public InputMaster controls;

    [SerializeField] private GameObject cannonBall;
    Rigidbody2D rb, rb2, rb3;

    private int ammo;
    private PlayerMovement playerNum; //checks player number for removing ammo from a particular player
    public CrewManager gunCount; //checks for how many cannons are fired in Fire method (Default 1)

    private float shootInput; 

    public bool reload = false; //checking for need to reload cannons
    public float cooldown; //changes based on crew members
    public float timer; //counts down from cooldown

    private void Awake()
    {
        controls = new InputMaster();
    }
    private void Start()
    {
        playerNum = this.gameObject.GetComponent<PlayerMovement>();
        controls.Player.Cannons.performed += ctx => ShootDirection();
        controls.Player2.Cannons.performed += ctx => ShootDirection();


    }
    private void Update()
    {
        if (reload == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer < 0)
        {
            timer = 0;
            ReloadGuns();
        }
    }
        private void ShootDirection()
        {

        //Check how much ammo player once fired so that it doesn't clog the update
        switch (playerNum.playerNumber)
        {
            case 1:
                ammo = AmmoManager.ammoNumberP1;
                break;
            case 2:
                ammo = AmmoManager.ammoNumberP2;
                break;
            default:
                break;
        }
        //reading player input
        switch (playerNum.playerNumber)
            {
                case 1:
                    shootInput = controls.Player.Cannons.ReadValue<float>();
                break;
                case 2:
                    shootInput = controls.Player2.Cannons.ReadValue<float>();
                    break;
                default:
                    break;
            }

        //Determining the player, the side fired off of and if there is ammo
        if (shootInput > 0 && ammo > 0 && playerNum.playerNumber == 1)
        {
          
            switch (gunCount.gunNumber)
            {
                case 1:
                    Fire(this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(6).position);
                    break;
                case 2:
                    Fire2(this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(6).position, this.gameObject.transform.GetChild(2).position, this.gameObject.transform.GetChild(8).position);
                    break;
                case 3:
                    Fire3(this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(6).position, this.gameObject.transform.GetChild(2).position, this.gameObject.transform.GetChild(8).position, this.gameObject.transform.GetChild(4).position, this.gameObject.transform.GetChild(9).position);
                    break;
                default:
                    break;
            }

        }
        if (shootInput < 0 && ammo > 0 && playerNum.playerNumber == 1)
        {
            switch (gunCount.gunNumber)
            {
                case 1:
                    Fire(this.gameObject.transform.GetChild(1).position, this.gameObject.transform.GetChild(7).position);
                    break;
                case 2:
                    Fire2(this.gameObject.transform.GetChild(1).position, this.gameObject.transform.GetChild(7).position, this.gameObject.transform.GetChild(3).position, this.gameObject.transform.GetChild(10).position);
                    break;
                case 3:
                    Fire3(this.gameObject.transform.GetChild(1).position, this.gameObject.transform.GetChild(7).position, this.gameObject.transform.GetChild(3).position, this.gameObject.transform.GetChild(10).position, this.gameObject.transform.GetChild(5).position, this.gameObject.transform.GetChild(11).position);
                    break;
                default:
                    break;
            }

        }
        if (shootInput > 0 && ammo > 0 && playerNum.playerNumber == 2)
        {

            switch (gunCount.gunNumber)
            {
                case 1:
                    Fire(this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(6).position);
                    break;
                case 2:
                    Fire2(this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(6).position, this.gameObject.transform.GetChild(2).position, this.gameObject.transform.GetChild(8).position);
                    break;
                case 3:
                    Fire3(this.gameObject.transform.GetChild(0).position, this.gameObject.transform.GetChild(6).position, this.gameObject.transform.GetChild(2).position, this.gameObject.transform.GetChild(8).position, this.gameObject.transform.GetChild(4).position, this.gameObject.transform.GetChild(9).position);
                    break;
                default:
                    break;
            }

        }
        if (shootInput < 0 && ammo > 0 && playerNum.playerNumber == 2)
        {
            switch (gunCount.gunNumber)
            {
                case 1:
                    Fire(this.gameObject.transform.GetChild(1).position, this.gameObject.transform.GetChild(7).position);
                    break;
                case 2:
                    Fire2(this.gameObject.transform.GetChild(1).position, this.gameObject.transform.GetChild(7).position, this.gameObject.transform.GetChild(3).position, this.gameObject.transform.GetChild(10).position);
                    break;
                case 3:
                    Fire3(this.gameObject.transform.GetChild(1).position, this.gameObject.transform.GetChild(7).position, this.gameObject.transform.GetChild(3).position, this.gameObject.transform.GetChild(10).position, this.gameObject.transform.GetChild(5).position, this.gameObject.transform.GetChild(11).position);
                    break;
                default:
                    break;
            }

        }
    }
     
    //the actual creation of a cannonball and the direction it goes off in
    public void Fire(Vector3 broadside, Vector3 endPoint)
    {
        if (reload == false)
        {
            rb = cannonBall.GetComponent<Rigidbody2D>(); //you need to get this on each fire, and not start because you need the rigidbody for each new prefab instantiated 
            rb = Instantiate(rb, broadside, Quaternion.identity);

            Vector3 shootDir = (broadside - endPoint).normalized;
            rb.GetComponent<CannonBall>().Setup(shootDir);


            reload = true;

             switch (playerNum.playerNumber)
             {
                 case 1:
                     AmmoManager.ammoNumberP1 --;
                     break;
                 case 2:
                     AmmoManager.ammoNumberP2 --;
                     break;
                 default:
                     break;
             }
        }    
    }
    //two cannons
    public void Fire2 (Vector3 broadside, Vector3 endPoint, Vector3 broadside2, Vector3 endPoint2)
    {
        if (reload == false)
        {
            rb = cannonBall.GetComponent<Rigidbody2D>(); //you need to get this on each fire, and not start because you need the rigidbody for each new prefab instantiated 
            rb = Instantiate(rb, broadside, Quaternion.identity);
            rb2 = cannonBall.GetComponent<Rigidbody2D>(); 
            rb2 = Instantiate(rb2, broadside2, Quaternion.identity);

            Vector3 shootDir = (broadside - endPoint).normalized;
            Vector3 shootDir2 = (broadside2 - endPoint2).normalized;
            rb.GetComponent<CannonBall>().Setup(shootDir);
            rb2.GetComponent<CannonBall>().Setup(shootDir2);

            reload = true;


            switch (playerNum.playerNumber)
            {
                case 1:
                    AmmoManager.ammoNumberP1 -= 1;
                    break;
                case 2:
                    AmmoManager.ammoNumberP2 -= 1;
                    break;
                default:
                    break;
            }
        }
    }

    //three cannons
    public void Fire3(Vector3 broadside, Vector3 endPoint, Vector3 broadside2, Vector3 endPoint2, Vector3 broadside3, Vector3 endPoint3)
    {
        if (reload == false)
        {
            rb = cannonBall.GetComponent<Rigidbody2D>(); //you need to get this on each fire, and not start because you need the rigidbody for each new prefab instantiated 
            rb = Instantiate(rb, broadside, Quaternion.identity);
            rb2 = cannonBall.GetComponent<Rigidbody2D>();
            rb2 = Instantiate(rb2, broadside2, Quaternion.identity);
            rb3 = cannonBall.GetComponent<Rigidbody2D>();
            rb3 = Instantiate(rb3, broadside3, Quaternion.identity);


            Vector3 shootDir = (broadside - endPoint).normalized;
            Vector3 shootDir2 = (broadside2 - endPoint2).normalized;
            Vector3 shootDir3 = (broadside3 - endPoint3).normalized;

            rb.GetComponent<CannonBall>().Setup(shootDir);
            rb2.GetComponent<CannonBall>().Setup(shootDir2);
            rb3.GetComponent<CannonBall>().Setup(shootDir3);

            reload = true;


            switch (playerNum.playerNumber)
            {
                case 1:
                    AmmoManager.ammoNumberP1 -= 1;
                    break;
                case 2:
                    AmmoManager.ammoNumberP2 -= 1;
                    break;
                default:
                    break;
            }
        }
    }
    public void ReloadGuns()
    {
            reload = false;
            timer = cooldown;
       
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
