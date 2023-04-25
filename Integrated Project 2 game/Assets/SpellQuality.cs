using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SpellQuality : MonoBehaviour
{
public void ShowPopup()
{
    gameObject.GetComponent<Animation>().Play("Quality Popup");
}

}
