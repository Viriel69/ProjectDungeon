using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicalKitScript : MonoBehaviour
{
    [SerializeField] private HealthScript healthScript;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            healthScript.currentHP += 10f;
            Destroy(this.gameObject);
        }
    }
}
