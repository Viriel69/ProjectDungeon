using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    public float maxHP = 100f;
    public float currentHP;
    private bool isAlive;

    private void Awake()
    {
        currentHP = maxHP;
        isAlive = true;
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        CheckIsAlive();
        IsAlive();
    }

    private void CheckIsAlive()
    {
        if (currentHP > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false;
        }
    }

    private void IsAlive()
    {
        if (isAlive == false)
        {
            Destroy(this.gameObject);
        }
    }
}
