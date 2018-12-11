using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateWalkingAnimation : MonoBehaviour
{
	public Animator Animator;

	/*Unused Code
	Original walk = false;

	col.collider2D.tag == "Ground"
	*/

	// Walking alimation


	void Start()
	{
		

	}

	public void Walking()
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

	// Update is called once per frame
	void Update()
	{
		


		//Other
		Walking();


	}




}
