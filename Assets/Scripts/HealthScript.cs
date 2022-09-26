using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [SerializeField] private GameObject DeathPanel;
    public float maxHP = 100f;
    public float currentHP;
    private bool isAlive;
    private Animator animator;

    private void Awake()
    {
        currentHP = maxHP;
        isAlive = true;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage) 
    {
        currentHP -= damage;
        animator.SetTrigger("IsDamage");
        CheckIsAlive();
        IsAlive();
    }

    private void CheckIsAlive() 
    {
        if(currentHP > 0) 
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
            DeathPanel.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
