using UnityEngine;

public class ARController : MonoBehaviour
{
    // This method will be called from JavaScript to start the camera
    public void StartCamera()
    {
        // Call the JavaScript function 'startARCameraFromUnity' when the button is pressed
        Application.ExternalCall("startARCameraFromUnity");
    }
}
