using UnityEngine;
using UnityEngine.UI;
 
public class ZetcilPlayerPref : MonoBehaviour
{
	[Header("Settings")]
	public string prefKey = "AudioVolume"; // Public key for PlayerPref
	public Slider volumeSlider; // Reference to the UI Slider
	public AudioSource audioSource; // Reference to the Audio Source
 
	void Start()
	{
    	// Load the saved volume or set a default value
    	float savedVolume = PlayerPrefs.GetFloat(prefKey, 1.0f);
    	volumeSlider.value = savedVolume;
        audioSource.volume = savedVolume;
 
    	// Listen for slider value changes
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
	}
 
	public void UpdateVolume(float value)
	{
    	// Update AudioSource volume
        audioSource.volume = value;
 
    	// Save the volume in PlayerPrefs
        PlayerPrefs.SetFloat(prefKey, value);
        PlayerPrefs.Save();
	}
}
