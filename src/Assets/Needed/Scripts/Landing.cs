using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour
{

    public CharacterMovementAnimator cmAnimator;
    public CharacterMovement cMovement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cmAnimator.Land();
        cMovement.grounded = true;
    }
}
