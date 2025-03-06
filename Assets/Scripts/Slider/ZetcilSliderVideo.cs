using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ZetcilSliderVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Slider volumeSlider;
    public Slider progressSlider;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
        progressSlider.onValueChanged.AddListener(ChangeVideoTime);
    }

    void Update()
    {
        if (videoPlayer.isPlaying)
            progressSlider.value = (float)(videoPlayer.time / videoPlayer.length);
    }

    void ChangeVolume(float value)
    {
        videoPlayer.SetDirectAudioVolume(0, value);
    }

    void ChangeVideoTime(float value)
    {
        videoPlayer.time = value * videoPlayer.length;
    }
}
