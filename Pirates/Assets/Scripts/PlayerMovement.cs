﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject compass; //Wind game object to be accessed by windDirection variable
	Rigidbody2D rb;
	private Wind windDirection;
	public int playerNumber;
	private string Player;

	[SerializeField]
	public float accelerationPower = 10f;
	[SerializeField]
	public float steeringPower = 1f;
	public float speedModifier;
	float steeringAmount, speed, direction;
	

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		windDirection = compass.GetComponent<Wind>();
		Player = ("Player") + playerNumber;
	}

	void FixedUpdate() 
	{

		WindCheck();

		steeringAmount = Input.GetAxis("Horizontal" + playerNumber);
		speed = Input.GetAxis("Vertical" + playerNumber) * accelerationPower;
		
		direction = Mathf.Sign(Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up))); //all the math is stolen, I couldn't steer it properly myself
		rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;

		rb.AddRelativeForce(-Vector2.up * speed);

		rb.AddRelativeForce(-Vector2.right * steeringAmount); // 2); //* rb.velocity.magnitude was originally in the middle of the equation, but I wanted to turn even without moving forward (i.e. when stuck), and this prevented that
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
