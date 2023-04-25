using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouseScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }
}
