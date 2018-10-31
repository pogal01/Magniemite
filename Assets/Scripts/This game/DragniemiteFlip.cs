using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragniemiteFlip : MonoBehaviour
{




	public bool FlipGrav;
	// Use this for initialization
	public bool Activite;
	void Start()
	{
		FlipGrav = false;
		Activite = true;
		Physics2D.gravity = new Vector2(0, -9.8f);


	}



	void FlipScript()
	{
		if (Input.GetMouseButtonDown(0))

		{
			FlipGrav = !FlipGrav;

			if (FlipGrav)
			{
				Physics2D.gravity = new Vector2(0, 9.8f);
				Debug.Log("Fliped");
				
			}

			else
			{

				Physics2D.gravity = new Vector2(0, -9.8f);
				Debug.Log("Normal");
				

			}


		}
	}


	//Fixed update

	void Update()
	{

		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 0)
		{
			if (GameObject.Find("Magneimite").GetComponent<Flip>().Activite == true)
			{

				FlipScript();

			}
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 1)
		{
			if (GameObject.Find("Cute").GetComponent<RealFlip>().Activite == true)
			{

				FlipScript();

			}
		}
		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 2)
		{
			if (GameObject.Find("Dragniemite").GetComponent<DragniemiteFlip>().Activite == true)
			{

				FlipScript();

			}
		}

		if (GameObject.Find("InvisablePufferfish3").GetComponent<ChoseSkin>().CharacterPicked == 3)
		{
			if (GameObject.Find("Magnieling").GetComponent<DragniemiteFlip>().Activite == true)
			{

				FlipScript();

			}
		}

		if (GameObject.Find("EndWall").GetComponent<GameOver>().End == true)
		{
			Activite = false;
		}

		if (GameObject.Find("Spike").GetComponent<Spawn_loc1>().Reseting == true)
		{
			Activite = true;
		}

	}
}



