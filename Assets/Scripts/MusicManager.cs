using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
	AudioSource audioSource;

	void Start ()
    {
		audioSource = GetComponent<AudioSource>();
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	}
	
	public void SetVolume (float volume)
    {
		audioSource.volume = volume;
	}
}
