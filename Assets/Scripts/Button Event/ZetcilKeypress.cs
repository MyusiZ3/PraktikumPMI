using UnityEngine;
using UnityEngine.Events;

public class ZetcilKeypress : MonoBehaviour
{
    [Header("Key Settings")]
    public KeyCode targetKey = KeyCode.Space;
    
    [Header("Events")]
    public UnityEvent onKeyDown;
    public UnityEvent onKeyPress;
    public UnityEvent onKeyUp;

    private bool isKeyPressed = false;

    void Update()
    {
        if (Input.GetKeyDown(targetKey))
        {
            onKeyDown.Invoke();
            isKeyPressed = true;
        }
        
        if (isKeyPressed && Input.GetKey(targetKey))
        {
            onKeyPress.Invoke();
        }
        
        if (Input.GetKeyUp(targetKey))
        {
            onKeyUp.Invoke();
            isKeyPressed = false;
        }
    }
}
