﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    public PlayerPlatformerController control;
    public Animator animator;
    public AudioManager audioM;

    PlayerControls padControls;

    float horMove;

    public float speed = 40f;

    bool jump = false;

    Vector2 move;

    private void Awake()
    {
        padControls = new PlayerControls();

        padControls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        padControls.Gameplay.Move.performed += ctx => move = Vector2.zero;
        padControls.Gameplay.Jump.performed += ctx => Jump();
    }

    private void OnEnable()
    {
        padControls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        padControls.Gameplay.Disable();
    }


    private void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);


        horMove = Input.GetAxisRaw("Horizontal")*speed;

        animator.SetFloat("speed", Mathf.Abs(horMove));
        
        if (Input.GetButtonDown("Jump"))
        {
            Jump();

        }

    }

    void Jump()
    {
        jump = true;
        animator.SetBool("inAir", true);
        
    }

    public void Land()
    {
        animator.SetBool("inAir", false);
        //audioM.Play("Jump_Land", 0);
        
    }

    private void FixedUpdate()
    {

        control.Move(horMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}