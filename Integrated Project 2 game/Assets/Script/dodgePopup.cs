using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class dodgePopup : MonoBehaviour
{
    public GameObject parent;
    private float disapearTimer;
void Awake()
{
    disapearTimer = 2;
    gameObject.GetComponent<Animation>().Play("Dodge Popup");
}
void Update()
{
    disapearTimer -=Time.deltaTime;
    if(disapearTimer <= 0)
    {
        Destroy(parent);
    }
}
}
