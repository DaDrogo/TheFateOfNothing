using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioManager audioM;
    public Footsteps steps;

    int position;
    bool laufen;
    int type =0;


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "start" &&type==0)
        {
            audioM.Play("Wind-Flach", 0);
            type = 1;
            steps.type = "gras";
        }
        else if (col.tag == "house" && type == 1)
        {
            steps.type = "wood";
            type = 0;
            audioM.Play("Wind-Flach", 1);
        }

        else if (col.tag == "garden"&&type==0)
        {
            type = 1;
            audioM.Play("Garten-Nacht", 0);
            audioM.Play("Nacht-Regen", 1);
            audioM.Play("Street", 1);
            steps.type = "gras";
        }
        else if(col.tag == "street" && type == 1)
        {
            audioM.Play("Garten-Nacht", 1);
            audioM.Play("Wind-Flach", 1);
            audioM.Play("Street", 0);
            steps.type = "gravel";
        }
        else if (col.tag == "rain"&&type==1)
        {
            type = 0;
            audioM.Play("Garten-Nacht", 1);
            audioM.Play("Nacht-Regen", 0);
            steps.type = "water";
        }

        else if (col.tag == "lightWind"&&type==0)
        {
            type = 1;
            audioM.Play("Nacht-Regen", 1);
            audioM.Play("Wind-Berg", 1);
            audioM.Play("Street", 1);
            audioM.Play("Wind-Flach", 0);
            steps.type = "gras";
        }
        else if (col.tag == "strongWind"&&type==1)
        {
            type = 0;
            audioM.Play("Wind-Berg", 0);
            audioM.Play("Wind-Flach", 1);
            steps.type = "gravel";
        }
        else if (col.tag == "farm"&&type==0)
        {
            type = 1;
            audioM.Play("Wind-Berg", 1);
            audioM.Play("Feld", 0);
            audioM.Play("Meer", 1);
            steps.type = "gras";
        }
        else if (col.tag == "sea"&&type==1)
        {
            type = 0;
            audioM.Play("Feld", 1);
            audioM.Play("Meer", 0);
            steps.type = "gras";
        }
        else if (col.tag == "office")
        {
            steps.type = "wood";
            audioM.Play("Office", 0);
            audioM.Play("Street", 1);
        }
        else if (col.tag == "war")
        {
            steps.type = "water";
            audioM.Play("Office", 1);
            audioM.Play("Wind-Berg",0);
        }
       
    }

    
}
