using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagniemiteAlimation : MonoBehaviour
{
	public Animator Animator;
	private GameObject Magniemite;
	private GameObject InvisPuffer5;
	/*Unused Code
	Original walk = false;
	*/

	// Walking alimation

		private void Awake()
		{
		Magniemite = GameObject.Find("Magneimite");
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");


		}


	void Start()
	{
	StopAnimateHit();
	StopAnimateRez();
	StopDeathAlimation();
	}

	void Walk()
	{
		if (Magniemite.GetComponent<CeliingGroundCheck>().Grounded == true)
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
		Animator.SetBool("RoleBack", true);
	}

	public void StopDeathAlimation()
	{
		Animator.SetBool("RoleBack", false);
	}


	// Update is called once per frame
	void Update()
	{
		//True
	


		if (InvisPuffer5.GetComponent<Player_Start>().BeenHit == true)
		{
			AnimateHit();
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
		Walk();


	}




}
