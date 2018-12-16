using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragniemiteAlimation : MonoBehaviour
{
	public Animator Animator;

	private GameObject InvisPuffer5;

	/*Unused Code
	Original walk = false;
	*/

	// Walking alimation

	private void Awake()
	{
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}
	void Start()
	{
		AnimateF();
		StopAnimateHit();
		StopAnimateRez();
		StopDeathAlimation();

	}



	public void AnimateF() // F = Fly
	{
		Animator.SetBool("IsFlying", true);
	}



	public void AnimateFfalse() // F = Fly
	{
		Animator.SetBool("IsFlying", false);

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


		if (InvisPuffer5.GetComponent<Player_Start>().MagnieWalk == true)
		{
			AnimateF();
		}

		if (InvisPuffer5.GetComponent<Player_Start>().MagnieWalk == true)
		{
			AnimateF();
		}

		if (InvisPuffer5.GetComponent<Player_Start>().BeenHit == true)
		{
			AnimateHit();

			//FindObjectOfType<AudioMannager>().Play("Hit");
		}

		if (InvisPuffer5.GetComponent<Player_Start>().Rez == true)
		{
			AnimateRez();
		}

		if (InvisPuffer5.GetComponent<Player_Start>().Dead == true)
		{
			StartDeathAlimation();
		}


		//False
		if (InvisPuffer5.GetComponent<Player_Start>().MagnieWalk == false)
		{
			AnimateFfalse();
		}


		if (InvisPuffer5.GetComponent<Player_Start>().BeenHit == false)
		{
			StopAnimateHit();
		}

		if (InvisPuffer5.GetComponent<Player_Start>().Rez == false)
		{
			StopAnimateRez();
		}


		if (InvisPuffer5.GetComponent<Player_Start>().Dead == false)
		{
			StopDeathAlimation();
		}

		//Other



	}

}
