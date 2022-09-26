using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBarrierTrigger : MonoBehaviour
{
    [SerializeField] private GameObject barrier;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            barrier.SetActive(false);
            transform.position = new Vector3((float)(transform.position.x + 0.2), transform.position.y);
        }
    }
}
