using UnityEngine;

public class TouchInputTest : MonoBehaviour
{
    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);
                Debug.Log("Touch " + i + ": Position " + touch.position + ", Phase " + touch.phase);
            }
        }

#if UNITY_EDITOR
        // Check for mouse input as a touch simulation
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse: Position " + Input.mousePosition + ", Phase Began");
        }
        else if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse: Position " + Input.mousePosition + ", Phase Moved/Stationary");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse: Position " + Input.mousePosition + ", Phase Ended");
        }
#endif
    }
}
