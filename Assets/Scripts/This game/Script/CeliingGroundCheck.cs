using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeliingGroundCheck : MonoBehaviour {
	public bool Grounded = false;


	public void OnCollisionEnter2D()
	{

		Grounded = true;


	}
	public void OnCollisionExit2D()
	{

		Grounded = false;



	}


}
