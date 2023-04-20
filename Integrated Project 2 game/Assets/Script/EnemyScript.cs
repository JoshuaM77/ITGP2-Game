using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] public Transform pfDamagePopup;

    public int maximumDamage;
    public int minumumDamage;
    public int criticalDamage;
    private int damageToPlayer;
    public GameHandler gameHandler;

    void Start()
    {

    }
    public void EnemyTurn()
    {
        damageToPlayer = Random.Range(minumumDamage,maximumDamage);
        gameHandler.p1Damage(damageToPlayer);
        gameHandler.p2Damage(damageToPlayer);
        gameHandler.RestartTurn();
    }
    public void CreatePopup(int damageAmount)
    {
        Transform damagePopupTransform = Instantiate(pfDamagePopup, Vector3.zero,Quaternion.identity);
        DamagePopup damagePopup = damagePopupTransform.GetComponent<DamagePopup>();
        damagePopup.Setup(damageAmount);
    }
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
