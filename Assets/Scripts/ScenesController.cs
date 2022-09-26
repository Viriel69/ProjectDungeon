using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    [SerializeField] private int index;
    public void ChangeScene() 
    {
        SceneManager.LoadScene(index);
    }
}
