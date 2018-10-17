using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
	AudioSource audioSource;

	void Start ()
    {
        DontDestroyOnLoad(this);
		audioSource = GetComponent<AudioSource>();
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	}
	
	public void SetVolume (float volume)
  	{
        audioSource.volume = volume;
	}
}
