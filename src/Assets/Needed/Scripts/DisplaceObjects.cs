using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaceObjects : MonoBehaviour
{
    private float transparicy;

    public float value;

    public GameObject interactableGamobject;
    CharacterValues values;
    GameObject player;

    private void Update()
    {
        player = GameObject.Find(Var.CHARACTER);
        values = player.GetComponent<CharacterValues>();
        CheckTransparicy();
    }

    private void CheckTransparicy()
    {
        transparicy = values.Transparicy;

        if (transparicy > value)
        {
            //wenn die transparenz größer ist erscheint das object
            interactableGamobject.SetActive(true);
        }
        else if (transparicy <= value)
        {
            //wenn die transparenz kleiner ist verschwindet das object
            interactableGamobject.SetActive(false);
        }
    }
}
