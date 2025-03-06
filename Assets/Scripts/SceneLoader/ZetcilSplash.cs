using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZetcilSplash : MonoBehaviour
{
    [Header("Scene Settings")]
    public string nextSceneName = "MainMenu"; // The scene to load
    public float delayBeforeLoad = 3f; // Delay before loading the next scene

    void Start()
    {
        StartCoroutine(SplashSequence());
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    IEnumerator SplashSequence()
    {
        // Fade in the splash image
        float elapsedTime = 0;

        // Wait before loading the next scene
        yield return new WaitForSeconds(delayBeforeLoad);

        // Load the next scene
        SceneManager.LoadScene(nextSceneName);
    }
}
