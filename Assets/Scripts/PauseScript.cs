using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;
    private bool inActive = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inActive == true) 
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
            inActive = false;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && inActive == false) 
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1;
            inActive = true;
        }
    }
    public void PauseButton() 
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        inActive = true;
    }
}
