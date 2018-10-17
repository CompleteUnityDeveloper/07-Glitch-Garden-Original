using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	[SerializeField] Slider volumeSlider;
    [SerializeField] Slider diffSlider;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] float defaultDifficulty = 2f;

	void Start()
    {
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		diffSlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	void Update() // So that we hear the volume change
    {
		var musicPlayer = FindObjectOfType<MusicPlayer>();
		if (musicPlayer)
		{
			musicPlayer.SetVolume(volumeSlider.value);
		}
		else
		{
			Debug.LogWarning("No music player found by " + name + " . Did you start from splash screen?");
		}

	}
	
	public void SaveAndExit()
    {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty(diffSlider.value);
		FindObjectOfType<LevelLoader>().StartGame();
	}
	
	public void SetDefaults()
    {
		volumeSlider.value = defaultVolume;
		diffSlider.value = defaultDifficulty;
	}
}
