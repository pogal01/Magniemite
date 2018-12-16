using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnielingFlip : MonoBehaviour
{



	public Animator Animator;
	public bool FlipGrav;
	// Use this for initialization
	public bool Activite;

	private GameObject Endwall;
	private GameObject Spike1;

	private void Awake()
	{
		Endwall = GameObject.Find("EndWall");
		Spike1 = GameObject.Find("Spike");
	}
	void Start()
	{
		FlipGrav = false;
		Activite = true;
		Physics2D.gravity = new Vector2(0, -9.8f);


	}

	public void FlipAnimation()
	{
		Animator.SetBool("Fliped", true);
	}
	public void FlipAnimation2()
	{
		Animator.SetBool("Fliped", false);
	}

	void FlipScript()
	{
		if (Input.GetMouseButtonDown(0))

		{
			FlipGrav = !FlipGrav;

			if (FlipGrav)
			{
				Physics2D.gravity = new Vector2(0, 9.8f);
				//Debug.Log("Fliped");
				FlipGrav = true;
				FlipAnimation();
			}

			else
			{

				Physics2D.gravity = new Vector2(0, -9.8f);
				//Debug.Log("Normal");
				FlipGrav = false;
				FlipAnimation2();
			}


		}
	}


	//Fixed update

	void Update()
	{

		if(Activite == true)
		{
			FlipScript();
		}

		if (Endwall.GetComponent<GameOver>().End == true)
		{
			Activite = false;
		}

		if (Spike1.GetComponent<Spawn_loc1>().Reseting == true)
		{
			Activite = true;
		}



		
	}
}



