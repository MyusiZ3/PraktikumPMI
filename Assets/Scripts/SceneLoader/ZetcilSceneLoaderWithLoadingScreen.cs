
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
 
public class ZetcilSceneLoaderWithLoadingScreen : MonoBehaviour
{
	public GameObject loadingScreen;
	public string sceneToLoad;
	public float minLoadTime = 1f; // Ensures the screen is visible for at least 1 second
 
	public void StartLoading()
	{
        StartCoroutine(LoadSceneWithDelay());
	}
 
	IEnumerator LoadSceneWithDelay()
	{
        loadingScreen.SetActive(true);
    	yield return new WaitForSeconds(minLoadTime);
        SceneManager.LoadScene(sceneToLoad);
	}
}

