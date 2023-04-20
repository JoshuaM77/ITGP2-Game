using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform MainCamera;

    public int CameraPosition;
    
    private void Start()
    {
        CameraPosition = 0;
        MainCamera.transform.position = new Vector3(62, 761, -1080);
    }


    public void MoveCameraForward()
    {
        CameraPosition = CameraPosition + 1;

        if (CameraPosition == 1)
            MainCamera.transform.position = new Vector3(62, 761, 00);
        else if (CameraPosition == 2)
            MainCamera.transform.position = new Vector3(62, 761, 1080);
    }

    public void MoveCameraBack()
    {
        CameraPosition = CameraPosition - 1;

        if (CameraPosition == 1)
            MainCamera.transform.position = new Vector3(62, 761, 00);
        else if (CameraPosition == 0)
            MainCamera.transform.position = new Vector3(62, 761, -1080);

        
    }


}
