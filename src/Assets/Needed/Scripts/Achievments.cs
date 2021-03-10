using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievments : MonoBehaviour
{
    public GameObject symbol;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == Var.PLAYER)
        {
            symbol.SetActive(true);
        }
    }  
}
