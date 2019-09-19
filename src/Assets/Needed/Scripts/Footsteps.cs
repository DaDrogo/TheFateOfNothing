using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public PlayerPlatformerController controller;
    public AudioManager audios;

    public string type;


    private void Update()
    {
        
    }

    private void PlayStep()
    {
        if (controller.grounded == true && controller.velocity.magnitude > 2f && type == "gras")
        {
            audios.Play("Gras_Step", 3);
        }
        else if (controller.grounded == true && controller.velocity.magnitude > 2f && type == "gravel")
        {
            audios.Play("Gravel_Step", 4);
        }
        else if (controller.grounded == true && controller.velocity.magnitude > 2f && type == "water")
        {
            audios.Play("Water_Step", 2);
        }
        else if (controller.grounded == true && controller.velocity.magnitude > 2f && type == "wood")
        {
            audios.Play("Wood_Step", 3);
        }

        if(controller.grounded == true && controller.velocity.magnitude > 2f)
        {
            
        }

    }
}
