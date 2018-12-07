using UnityEngine;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour
{
	public bool scriptActive;
	//public int materialIndex = 0;
	public Vector2 uvAnimationRate = new Vector2(1.0f, 0.0f);
	public string textureName = "_MainTex";
	Vector2 uvOffset = Vector2.zero;

	void Start()
	{
		scriptActive = true;
	}


	void LateUpdate()
	{
		if (scriptActive == true)
		{
			uvOffset += (uvAnimationRate * Time.deltaTime);
		if (GetComponent<Renderer>().enabled)
			{
			GetComponent<Renderer>().sharedMaterial.SetTextureOffset(textureName, uvOffset);
			}
		}


		if (GameObject.Find("EndWall").GetComponent<GameOver>().End == true)
		{
			scriptActive = false;

		}

		
	
		if (GameObject.Find("InvisablePufferfish5").GetComponent<Player_Start>().TriggrBackGround == true)
		{
			scriptActive = true;
		}
				
				
		
		
	}

	




}


