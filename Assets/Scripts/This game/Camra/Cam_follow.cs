using UnityEngine;

public class Cam_follow : MonoBehaviour {

	public Transform target;

	public float smoothspeed = 0.125f;

	public Vector3 offset;

	public float Velocity = -10f;

	public bool Activated = true;

	void Start()
	{
		transform.position = target.position + offset;
	}

	void Update()
	{
		if (GameObject.Find("EndWall").GetComponent<Eliminate_Player>().DestroyPlayer == true)
		{
			Activated = false;
			
		}
	}

	void FixedUpdate()
	{
		if(Activated == true)
		{
			if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Dead == true)
			{
				transform.Translate(Velocity * Time.deltaTime, 0, 0);
			}
		}
	}
		
}
