using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	[SerializeField] Slider volumeSlider;
    [SerializeField] Slider diffSlider;
    [SerializeField] float defaultVolume = 0.8f;
    [SerializeField] float defaultDifficulty = 2f;

    MusicManager musicManager;

	void Start ()
    {
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		diffSlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	 
	void Update ()
    {
		musicManager.SetVolume (volumeSlider.value);
	}
	
	public void SaveAndExit ()
    {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (diffSlider.value);
		FindObjectOfType<LevelLoader>().StartGame();
	}
	
	public void SetDefaults ()
    {
		volumeSlider.value = defaultVolume;
		diffSlider.value = defaultDifficulty;
	}
}
