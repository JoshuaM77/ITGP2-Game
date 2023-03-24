using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteButtonScript : MonoBehaviour
{
    public Sprite sprite;
    public Sprite Highlightsprite;

    public void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().sprite = Highlightsprite;
    }

    public void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
