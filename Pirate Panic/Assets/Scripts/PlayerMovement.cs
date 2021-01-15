using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


//This script handles more than just movement. I wish it was not named Player Movement but I'm too afraid to change it because of everything that references it
public class PlayerMovement : MonoBehaviour
{
	public GameObject compass; //Wind game object to be accessed by windDirection variable
	Rigidbody2D rb;
	private Wind windDirection;
	public int playerNumber;

	Animator tracers; //checks if player is flying with the wind
	public InputMaster controls;
	public Vector2 moveInput;

	[SerializeField]
	public float accelerationPower = 10f;

	[SerializeField]
	public float steeringPower = 1f;
	//modifier depends on how many crew, penalty is if hit by chainshot, and powerup is for picking up a speed boost
	public float speedModifier, speedPenalty, speedPowerup;
	float steeringAmount, speed, direction;

	public static string interaction, secondInteraction; //second interaction checks if player 2 interacts with something without overwriting player1's interaction

	public float damageModifier = 1;

	private void Awake()
	{
		controls = new InputMaster();
	}

	void Start()
	{
		tracers = this.gameObject.GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
		windDirection = compass.GetComponent<Wind>();
		controls.Player.Interact.performed += ctx => Interact(interaction, secondInteraction);
		controls.Player2.Interact.performed += ctx => Interact(interaction, secondInteraction);
		
	}

	private void Update()
	{
		Move();
	}
	void FixedUpdate() 
	{
		
		WindCheck();
		ApplyMovement();
		Ram();
		SlowSpeed();

	}

	private void Move()
	{
		//reading player input
		switch (playerNumber)
		{
			case 1:
				moveInput = controls.Player.Movement.ReadValue<Vector2>();
				break;
			case 2:
				moveInput = controls.Player2.Movement.ReadValue<Vector2>();
				break;
			default:
				break;
		}
	}
	void ApplyMovement()
	{

		steeringAmount = moveInput.x;
		speed = moveInput.y * accelerationPower - speedPenalty;
		direction = Mathf.Sign(Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up))); //all the math is stolen, I couldn't steer it properly myself
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;

		//if chainshot wrecks someone's speed 
		if (speed < 0)
		{
			speed = 0;
		}

		rb.AddRelativeForce(-Vector2.up * speed);

		rb.AddRelativeForce(-Vector2.right * steeringAmount); // 2); //* rb.velocity.magnitude was originally in the middle of the equation, but I wanted to turn even without moving forward (i.e. when stuck), and this prevented that

		//when going in the wind you get tracers showing speed boost
		if (accelerationPower >= 20f && moveInput.y > 0)
		{
			tracers.SetBool("isMoving", true);
		}
		else
		{
			tracers.SetBool("isMoving", false);
		}

	}

	void Interact(string interactingWith, string interactingWith2)
	{
			switch (interactingWith)
			{
				case "PortPlayer1":
					AmmoManager.ammoNumberP1 = 10;
				Port.pressed1 = true;
				break;
				case "PortPlayer2":
					AmmoManager.ammoNumberP2 = 10;
				Port.pressed2 = true;
				break;
				default:
					break;
			}

		switch (interactingWith2)
		{
			case "PortPlayer1":
				AmmoManager.ammoNumberP1 = 10;
				Port.pressed1 = true;
				break;
			case "PortPlayer2":
				AmmoManager.ammoNumberP2 = 10;
				Port.pressed2 = true;
				break;
			default:
				break;
		}

		
		
	}

	//player deals damage ramming other ships based on time moving in a straight line
	void Ram()
	{
		float maxDamage = 10 + accelerationPower;
		float minDamage = 0;

		damageModifier += (accelerationPower/2 * Time.deltaTime);
		if (moveInput.y == 0)
		{
			damageModifier = 0;
		}
		if (moveInput.x != 0)
		{
			damageModifier -= .25f;
		}
		if (damageModifier >= maxDamage)
		{
			damageModifier = maxDamage;
		}
		if (damageModifier <= 0)
		{
			damageModifier = minDamage;
		}
	}

	void SlowSpeed()
	{
		if (speedPenalty > 0)
		{
			speedPenalty -= Time.deltaTime;
		}

		if (speedPenalty < 0)
		{
			speedPenalty = 0;
		}
	}
	private void OnEnable()
	{
		controls.Enable();
	}

	private void OnDisable()
	{
		controls.Disable();
	}


	//stop playing moving animation while stuck
	private void OnCollisionEnter2D(Collision2D collision)
	{
		tracers.SetBool("Stuck", true);
	}
	private void OnCollisionExit2D(Collision2D collision)
	{
		tracers.SetBool("Stuck", false);
	}
	void WindCheck()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up);
		//WIND SPEED CHANGE 
		if (hit.collider.name == "North" + playerNumber)
		{
			if (windDirection.currentWind == "N") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier + speedPowerup;
			}
			else if (windDirection.currentWind == "S") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier + speedPowerup;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier + speedPowerup;
			}

		}
		else if (hit.collider.name == "South" + playerNumber)
		{
			if (windDirection.currentWind == "S") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier + speedPowerup;
			}
			else if (windDirection.currentWind == "N") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier + speedPowerup;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier + speedPowerup;
			}
		}
		else if (hit.collider.name == "East" + playerNumber)
		{
			if (windDirection.currentWind == "E") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier + speedPowerup;
			}
			else if (windDirection.currentWind == "W") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier + speedPowerup;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier + speedPowerup;
			}
		}
		else if (hit.collider.name == "West" + playerNumber)
		{
			if (windDirection.currentWind == "W") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier + speedPowerup;
			}
			else if (windDirection.currentWind == "E") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier + speedPowerup;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier + speedPowerup;
			}

		}


	}
}
