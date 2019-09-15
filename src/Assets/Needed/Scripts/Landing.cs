using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour
{

    public CharacterMovement cm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cm.Land();        
    }
}
