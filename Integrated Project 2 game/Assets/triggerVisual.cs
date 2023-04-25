using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class triggerVisual : MonoBehaviour
{
    public Sprite[] sprites;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[0];
    }
    public void Pressed(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
        GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
        else if(context.canceled)
        {
        GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
    }
}
