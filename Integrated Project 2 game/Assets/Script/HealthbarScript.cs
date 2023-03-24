using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarScript : MonoBehaviour
{

    private const float MAX_HEALTH = 100f;

    public float health = MAX_HEALTH;
    
    private Image healthBar;

    private void Start()
    {
        healthBar = GetComponent<Image>();
    }

    private void Update()
    {
        healthBar.fillAmount = health / MAX_HEALTH;
    }





}
