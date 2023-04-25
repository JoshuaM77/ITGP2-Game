using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class spellCircle : MonoBehaviour
{

    PlayerControls controls;
    public Transform trackingCircle;
    public float joytranslateX;
    public float joytranslateY;
    public float translateX;
    public float translateY;
    public float moveDistance;
    public Vector2 trackingCirclePos;
    


    void Awake()
    {
        controls = new PlayerControls();
        controls.Player.Newaction.performed += ctx => trackingCirclePos = ctx.ReadValue<Vector2>();
        controls.Player.Newaction.canceled += ctx => trackingCirclePos = Vector2.zero;
    }
    void Update()
    {
        Vector2 pos = new Vector2(trackingCirclePos.x, trackingCirclePos.y) *moveDistance;
        trackingCircle.localPosition = pos;

    }

    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }

}
