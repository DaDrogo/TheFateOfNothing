using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{

    public CharacterValues values;

    //wechsel zwischen rechenart
    public int type;

    public float value;

    bool calculate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == Var.PLAYER)
        {
            calculate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag==Var.PLAYER)
        {
            calculate = false;
        }
        
    }

    private void Update()
    {
        if (calculate == true)
        {
            Calculate();
        }
    }

    void Calculate()
    {
        if (type == 0)
        {
            //plus rechnen
            values.Transparicy = values.Transparicy + value * Time.deltaTime;
            
        }
        else if (type == 1)
        {
            //minus rechnen
            values.Transparicy = values.Transparicy - value * Time.deltaTime;
        }
        
    }


}
