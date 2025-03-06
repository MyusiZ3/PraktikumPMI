
using UnityEngine;
 
public class ZetcilAbout : MonoBehaviour
{
	public GameObject aboutPanel;
 
	public void Show()
	{
        aboutPanel.SetActive(true);
	}
 
	public void Hide()
	{
    	aboutPanel.SetActive(false);
	}
}

