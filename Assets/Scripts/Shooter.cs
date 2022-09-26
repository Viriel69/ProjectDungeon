using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform shotpos;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform parent_go;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Bullet, shotpos.transform.position, parent_go.rotation);
        }
    }
}
