using UnityEngine.Audio;
using System;
using UnityEngine;



[System.Serializable]

public class SoundEffects {


	
	public string Name;

	public AudioClip clip;

	[Range(0f,1f)]
	public float Volume;
	[Range(.1f, 3f)]
	public float Pitch;

	[Range(.1f, 256f)]
	public int priority;

	public bool loop;



	[HideInInspector]
	public AudioSource source;








	








}
