using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjects : MonoBehaviour
{
    public GameObject[] objects;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(GameObject ob in objects)
        {
            ob.SetActive(true);
        }
    }
}
