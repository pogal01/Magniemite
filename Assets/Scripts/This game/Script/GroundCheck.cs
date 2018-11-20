using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	public bool Ground = false;


	public void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Ground")
		{ 
		Ground = true;
		}

	}
	public void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Ground")
		{
			Ground = false;
		}


	}


}
