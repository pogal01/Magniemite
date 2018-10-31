//Attach this script to a 2D GameObject (for example a Sprite).
//Attach a Rigidbody component to the GameObject (Click the Add Component button and go to Physics 2D>Rigidbody 2D)

//This script allows you to change the direction of gravity in your Scene by pressing the space key in Play Mode.

using UnityEngine;

public class TestGrav : MonoBehaviour
{
	enum GravityDirection { Down, Left, Up, Right };
	GravityDirection m_GravityDirection;

	void Start()
	{
		m_GravityDirection = GravityDirection.Down;
	}

	void FixedUpdate()
	{
		switch (m_GravityDirection)
		{
			case GravityDirection.Down:
				//Change the gravity to be in a downward direction (default)
				Physics2D.gravity = new Vector2(0, -9.8f);
				//Press the space key to switch to the left direction
				if (Input.GetKeyDown(KeyCode.Space))
				{
					m_GravityDirection = GravityDirection.Left;
					Debug.Log("Left");
				}
				break;

			case GravityDirection.Left:
				//Change the gravity to go to the left
				Physics2D.gravity = new Vector2(-9.8f, 0);
				//Press the space key to change the direction of gravity
				if (Input.GetKeyDown(KeyCode.Space))
				{
					m_GravityDirection = GravityDirection.Up;
					Debug.Log("Up");
				}
				break;

			case GravityDirection.Up:
				//Change the gravity to be in a upward direction
				Physics2D.gravity = new Vector2(0, 9.8f);
				//Press the space key to change the direction
				if (Input.GetKeyDown(KeyCode.Space))
				{
					m_GravityDirection = GravityDirection.Right;
					Debug.Log("Right");
				}
				break;

			case GravityDirection.Right:
				//Change the gravity to go in the right direction
				Physics2D.gravity = new Vector2(9.8f, 0);
				//Press the space key to change the direction
				if (Input.GetKeyDown(KeyCode.Space))
				{
					m_GravityDirection = GravityDirection.Down;
					Debug.Log("Down");
				}

				break;
		}
	}
}