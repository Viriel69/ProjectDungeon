using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    [SerializeField] public Text textUI;

    private string text = "Уже много лет старая башня парит в небе над острыми скалами. " +
        "Много смельчаков пытались покорить её казематы, но так и остались в них навеки. " +
        "" +
        "Пришел и твой черед попытать счастье...";

    void Start()
    {
        StartCoroutine("showText", text);
    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {
            textUI.text = text.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.1f);
        }
    }
}
