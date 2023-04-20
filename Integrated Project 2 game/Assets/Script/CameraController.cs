using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{


   public void MoveUp()
    {
        if (transform.position.z >= 1080)
            return;
        transform.position += new Vector3(0, 0, 1080);
    }

    public void MoveDown()
    {
        if (transform.position.z <= -1080)
            return;
        transform.position -= new Vector3(0, 0, 1080);

        
    }
}
