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

	public InputMaster controls;
	public Vector2 moveInput;

	[SerializeField]
	public float accelerationPower = 10f;
	[SerializeField]
	public float steeringPower = 1f;
	public float speedModifier;
	float steeringAmount, speed, direction;

	public static string interaction;


	private void Awake()
	{
		controls = new InputMaster();
	}

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		windDirection = compass.GetComponent<Wind>();
		controls.Player.Escape.performed += ctx => Quit();
		controls.Player.Interact.performed += ctx => Interact(interaction);
		controls.Player2.Interact.performed += ctx => Interact(interaction);
		
	}

	private void Update()
	{
		Move();		
	}
	void FixedUpdate() 
	{

		WindCheck();
		ApplyMovement();

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
		speed = moveInput.y * accelerationPower;
		direction = Mathf.Sign(Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up))); //all the math is stolen, I couldn't steer it properly myself
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;


		rb.AddRelativeForce(-Vector2.up * speed);

		rb.AddRelativeForce(-Vector2.right * steeringAmount); // 2); //* rb.velocity.magnitude was originally in the middle of the equation, but I wanted to turn even without moving forward (i.e. when stuck), and this prevented that
	}

	void Interact(string interactingWith)
	{
			switch (interactingWith)
			{
				case "PortPlayer1":
					AmmoManager.ammoNumberP1 = 10;
					break;
				case "PortPlayer2":
					AmmoManager.ammoNumberP2 = 10;
					break;
				default:
					break;
			}
		Port.pressed = true;
		
	}

	private void OnEnable()
	{
		controls.Enable();
	}

	private void OnDisable()
	{
		controls.Disable();
	}

	private void Quit()
	{
		Application.Quit();
	}

	void WindCheck()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up);

		//WIND SPEED CHANGE 
		if (hit.collider.name == "North" + playerNumber)
		{
			if (windDirection.currentWind == "N") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier;
			}
			else if (windDirection.currentWind == "S") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier;
			}

		}
		else if (hit.collider.name == "South" + playerNumber)
		{
			if (windDirection.currentWind == "S") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier;
			}
			else if (windDirection.currentWind == "N") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier;
			}
		}
		else if (hit.collider.name == "East" + playerNumber)
		{
			if (windDirection.currentWind == "E") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier;
			}
			else if (windDirection.currentWind == "W") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier;
			}
		}
		else if (hit.collider.name == "West" + playerNumber)
		{
			if (windDirection.currentWind == "W") //WHEN MOVING WITH WIND, SPEED BECOMES 15F
			{
				accelerationPower = 15f + speedModifier;
			}
			else if (windDirection.currentWind == "E") //WHEN MOVING AGAINST WIND, SPEED BECOMES 5F
			{
				accelerationPower = 5f + speedModifier;
			}
			else //WHEN NEITHER WITH OR AGAINST WIND, SPEED IS 10F
			{
				accelerationPower = 10f + speedModifier;
			}

		}
	}
}
