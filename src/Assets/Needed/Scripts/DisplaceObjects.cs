using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaceObjects : MonoBehaviour
{
    float transpaicy;
    public float value;
    public GameObject interactableGamobject;

    public CharacterValues values;

    private void Update()
    {
        transpaicy = values.Transparicy;

        if(transpaicy > value)
        {
            //wenn die transparenz größer ist erscheint das object
            interactableGamobject.SetActive(true);
        }
        else if (transpaicy <= value)
        {
            //wenn die transparenz kleiner ist verschwindet das object
            interactableGamobject.SetActive(false);
        }

    }
}
