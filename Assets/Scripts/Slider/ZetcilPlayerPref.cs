using UnityEngine;
using UnityEngine.UI;

public class ZetcilPlayerPref : MonoBehaviour
{
    [Header("Settings")]
    public string prefKey = "AudioVolume"; // Public key for PlayerPref
    public Slider volumeSlider; // Reference to the UI Slider
    public AudioSource audioSource; // Reference to the Audio Source

    private static ZetcilPlayerPref instance; // Singleton untuk mencegah duplikasi

    void Awake()
    {
        // Pastikan hanya satu instance yang bertahan di antara scene
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Pastikan gameObject ini tetap ada saat pindah scene
        }
        else
        {
            Destroy(gameObject); // Jika sudah ada instance lain, hapus yang baru
            return;
        }
    }

    void Start()
    {
        // Load volume dari PlayerPrefs
        float savedVolume = PlayerPrefs.GetFloat(prefKey, 1.0f);
        volumeSlider.value = savedVolume;
        audioSource.volume = savedVolume;

        // Listen untuk perubahan nilai slider
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
    }

    public void UpdateVolume(float value)
    {
        // Update volume AudioSource
        audioSource.volume = value;

        // Simpan volume ke PlayerPrefs
        PlayerPrefs.SetFloat(prefKey, value);
        PlayerPrefs.Save();
    }
}
