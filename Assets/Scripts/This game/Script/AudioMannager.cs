using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioMannager : MonoBehaviour {




	public SoundEffects[] sounds;



	// Use this for initialization
	void Awake ()
	{

		foreach (SoundEffects s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;

			s.source.volume = s.Volume;
			s.source.pitch = s.Pitch;
			s.source.loop = s.loop;
			s.source.priority = s.priority;

		}



	}

	public void Play(string name)
	{

		SoundEffects s = Array.Find(sounds, sound => sound.Name == name);
		if (s == null)
		{

			Debug.LogWarning("Pog U fukd up and called your sound the wrong name u meme. "+ name + " Not found!!!");
			return;
		}
		s.source.Play();
	}
}
