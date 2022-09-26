using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCartTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject plank;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            plank.SetActive(true);
        }
    }
}
