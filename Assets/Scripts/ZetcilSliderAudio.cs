using UnityEngine;
using UnityEngine.UI;
 
public class ZetcilSliderAudio : MonoBehaviour
{
	public AudioSource audioSource;
	public Slider volumeSlider;
	public Slider progressSlider;
 
	void Start()
	{
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
        progressSlider.onValueChanged.AddListener(ChangeAudioTime);
	}
 
	void Update()
	{
        progressSlider.value = audioSource.time / audioSource.clip.length;
	}
 
	void ChangeVolume(float value)
	{
    	audioSource.volume = value;
	}
 
	void ChangeAudioTime(float value)
	{
        audioSource.time = value * audioSource.clip.length;
	}
}
