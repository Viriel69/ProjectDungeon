using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float damage;
    [SerializeField] private AudioSource audioS;
    [SerializeField] private AudioClip fire;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Damageable"))
        {
            collision.gameObject.GetComponent<EnemyHealthScript>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
