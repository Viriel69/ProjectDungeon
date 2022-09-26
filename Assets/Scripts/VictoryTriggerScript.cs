using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryTriggerScript : MonoBehaviour
{
    [SerializeField] private GameObject VictoryPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            VictoryPanel.SetActive(true);
            GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
            Destroy(gameObject);
        }
    }
}
