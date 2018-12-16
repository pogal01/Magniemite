using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateWalkingAnimation : MonoBehaviour
{
	public Animator Animator;

	private GameObject MagnilingCol;
	/*Unused Code
	Original walk = false;

	col.collider2D.tag == "Ground"
	*/

	// Walking alimation

		private void Awake()
		{
		MagnilingCol = GameObject.Find("MaglingCollision");
		}
	void Start()
	{
		

	}

	public void Walking()
	{

		if (MagnilingCol.GetComponent<GroundCheck>().Ground == true)
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
