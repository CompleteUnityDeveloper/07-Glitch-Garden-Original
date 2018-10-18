using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour
{
    // Consider region for the learning
    #region AllPrefs
    const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty"; // TODO use?
    #endregion

    const float MIN_DIFFICULTY = 1f;
    const float MAX_DIFFICULTY = 3f;
    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    // Static methods are encouraged, static variables aren't
    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME) // check valid range
        {
            Debug.Log("Setting " + MASTER_VOLUME_KEY + " to " + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}
        else
        {
			Debug.LogError ("Master volume out of range");
		}
	}
	
	public static float GetMasterVolume()
    {
        Debug.Log("Master vol is: " + PlayerPrefs.GetFloat(MASTER_VOLUME_KEY));
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	public static void SetDifficulty (float difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		}
        else
        {
			Debug.LogError ("Difficulty out of range");
		}
	}
	
	public static float GetDifficulty()
    {
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}