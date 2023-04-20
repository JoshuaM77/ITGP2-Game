using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using TMPro;

public class ItemCard : MonoBehaviour
{
    private Animation anim;
    public Item item;
    public TextMeshPro nameText;
    public TextMeshPro descriptText;
    public SpriteRenderer artwork;
    public Item[] itemList;
    private int index;

    void OnEnable()
    {
        index = Random.Range(0, itemList.Length);
        item = itemList[index];
        nameText.text = item.name;
        descriptText.text = item.description;
        artwork.sprite = item.Icon;
        anim = gameObject.GetComponent<Animation>();

        anim.Play("CardFlip");
    }
}
