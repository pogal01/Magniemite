using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptLink1 : MonoBehaviour
{

	public bool PickOriginal;
	public bool PickCute;
	public bool Dragnie;
	public bool Magling;
	public bool Link = false;
	public int CharacterPicked;
	public int PickedCharacter;
	public GameObject Original;
	public GameObject Cute;
	public GameObject Dragniemite;
	public GameObject Magnieling;
	public GameObject Selected;


	public void Start()
	{
		CharacterPicked = PlayerPrefs.GetInt("Character", 0);
		CheckChar();
		Link = true;
		

	}
	public void SaveChar()
	{
		Invoke("NotThatChar", 1);
		PlayerPrefs.SetInt("Character", PickedCharacter);
		CharacterPicked = PlayerPrefs.GetInt("Character", 0);

	}

	public void OriginalPicked()
	{
		PickOriginal = true;
		PickCute = false;
		Dragnie = false;
		PickedCharacter = 0;
	//	Debug.Log("OriginalPicked Picked");
		Selected.transform.position = Original.transform.position;
		SaveChar();
	}




	public void CutePicked()
	{
		PickCute = true;
		PickOriginal = false;
		Dragnie = false;
		PickedCharacter = 1;
	//	Debug.Log("Cute Picked");
		CharacterPicked = PlayerPrefs.GetInt("Character", 0);
		Selected.transform.position = Cute.transform.position;
		SaveChar();

	}

	public void DragniemitePicked()
	{
		Dragnie = true;
		PickCute = false;
		PickOriginal = false;
		PickedCharacter = 2;
	//	Debug.Log("Dragniemite Picked");
		Selected.transform.position = Dragniemite.transform.position;
		SaveChar();
	}

	public void MagnielingPicked()
	{
		Magling = true;
		Dragnie = false;
		PickCute = false;
		PickOriginal = false;
		PickedCharacter = 3;
		//	Debug.Log("Dragniemite Picked");
		Selected.transform.position = Magnieling.transform.position;
		SaveChar();
	}

	public void Next()
	{
		SceneManager.LoadScene("Start");
		Link = false;
	}
	public void Accept()
	{
		Invoke("Next", 1);
		CheckChar();
	}

	public void NotThatChar()
	{
		if (CharacterPicked != 0)
		{
			PickOriginal = false;
		}
		if (CharacterPicked != 1)
		{
			PickCute = false;
		}
		if (CharacterPicked != 2)
		{
			Dragnie = false;
		}
		if (CharacterPicked != 3)
		{
			Magling = false;
		}
	}

	public void CheckChar()
	{
		if (CharacterPicked == 0)
		{
			OriginalPicked();
		}

		if (CharacterPicked == 1)
		{
			CutePicked();
		}

		if (CharacterPicked == 2)
		{
			DragniemitePicked();
		}

		if (CharacterPicked == 3)
		{
			MagnielingPicked();
		}

	}


	void Update()
	{
		
	}
}
