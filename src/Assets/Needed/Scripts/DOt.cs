using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOt : MonoBehaviour
{

    public CharacterValues values;
    public int type;
    public float value;

    bool calculate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            calculate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag=="Player")
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
