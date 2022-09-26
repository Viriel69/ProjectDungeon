using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingScript : MonoBehaviour
{
    private int coinsCount;
    public Text coinsText;

    void Update()
    {
        coinsText.text = coinsCount.ToString();
    }

    public void Collecting() 
    {
        coinsCount += 1;
    }
}
