using System.Collections;
using UnityEngine;
using UnityEngine.Events;
 
public class ZetcilEvent : MonoBehaviour
{
	public float delay = 1.0f; // Delay time before invoking event
	public UnityEvent onDelayComplete; // UnityEvent to invoke
 
	void Start()
	{
        StartCoroutine(InvokeAfterDelay());
	}
 
	IEnumerator InvokeAfterDelay()
	{
    	yield return new WaitForSeconds(delay);
        onDelayComplete.Invoke();
	}
}
