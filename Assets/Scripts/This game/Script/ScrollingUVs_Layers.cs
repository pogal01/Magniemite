using UnityEngine;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour
{
	public bool scriptActive;
	//public int materialIndex = 0;
	public Vector2 uvAnimationRate = new Vector2(1.0f, 0.0f);
	public string textureName = "_MainTex";
	Vector2 uvOffset = Vector2.zero;

	private GameObject Endwall;
	private GameObject InvisPuff5;

	private void Awake()
	{
		Endwall = GameObject.Find("EndWall");
		InvisPuff5 = GameObject.Find("InvisablePufferfish5");
	}

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


		if (Endwall.GetComponent<GameOver>().End == true)
		{
			scriptActive = false;

		}

		
	
		if (InvisPuff5.GetComponent<Player_Start>().TriggrBackGround == true)
		{
			scriptActive = true;
		}
				
				
		
		
	}

	




}


