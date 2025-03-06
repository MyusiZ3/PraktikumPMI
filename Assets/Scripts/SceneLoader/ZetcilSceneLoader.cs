using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ZetcilSceneLoader : MonoBehaviour
{
	public string sceneToLoad;
 
	public void LoadScene()
	{
        SceneManager.LoadScene(sceneToLoad);
	}
}
