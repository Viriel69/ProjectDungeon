using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsController : MonoBehaviour
{
    private bool timer = false;
    private float time = 0.5f;
    private CollectingScript collecting;
    public GameObject PlayningField;

    private void Start()
    {
        collecting = PlayningField.GetComponent<CollectingScript>();
    }

    void Update()
    {
        Countdown();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collecting.Collecting();
            timer = true;
        }
    }

    void Countdown() 
    {
        if (timer) 
        {
            time -= 1f;
            if(time <= 0) 
            {
                Destroy(gameObject);
            }
        }
    }
}
