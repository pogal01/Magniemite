using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnielingAnimation : MonoBehaviour
{
	public Animator Animator;

	/*Unused Code
	Original walk = false;

	col.collider2D.tag == "Ground"
	*/
	
	// Walking alimation


	void Start()
	{
		StopAnimateHit();
		StopAnimateRez();
		StopDeathAlimation();

	}

	public void Walking ()
	{
		
		if (GameObject.Find("MaglingCollision").GetComponent<GroundCheck>().Ground == true)
		{
		AnimateW();
		//Debug.Log("Ground");
		}
		else
		{
			AnimateWfalse();
			
		}
	}

	public void AnimateW() // W = walk
	{
		Animator.SetBool("IsWalking", true);
	}



	public void AnimateWfalse() // W = walk
	{
		Animator.SetBool("IsWalking", false);

	}


	//Hit alimation
	public void AnimateHit()
	{
		Animator.SetBool("HasBeenHit", true);

	}

	public void StopAnimateHit()
	{
		Animator.SetBool("HasBeenHit", false);

	}

	// Rez alimatiion
	public void AnimateRez()
	{

		Animator.SetBool("HasBeenRezed", true);

	}

	public void StopAnimateRez()
	{

		Animator.SetBool("HasBeenRezed", false);
	}
	// Death alimation
	public void StartDeathAlimation()
	{
		Animator.SetBool("HasDied", true);
	}

	public void StopDeathAlimation()
	{
		Animator.SetBool("HasDied", false);
	}


	// Update is called once per frame
	void Update()
	{
		//True



		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().BeenHit == true)
		{
			AnimateHit();
		}

		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Rez == true)
		{
			AnimateRez();
		}

		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Dead == true)
		{
			StartDeathAlimation();
		}


		//False
	
		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().BeenHit == false)
		{
			StopAnimateHit();
		}

		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Rez == false)
		{
			StopAnimateRez();
		}


		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().Dead == false)
		{
			StopDeathAlimation();
		}

		//Other
		Walking();


	}




}
