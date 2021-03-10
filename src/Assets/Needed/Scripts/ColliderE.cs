using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderE : MonoBehaviour
{
    public GameObject showGrab;
    public GameObject showTeleport;
    public GameObject showDead;
    public GameObject player;
    public GameObject point;

    public CharacterValues values;
    public GameManage manager;

    public float trans_amount;
    public int type;

    private bool activated;

    private void Update()
    {
        if (Input.GetButtonDown("E")&&activated)
        {
            switch (type)
            {
                case 0:
                    ActivateItem();
                    break;
                case 1:
                    OpenDoor();
                    break;
                case 2:
                    manager.ResetGame();
                    break;
                case 3:
                    DeleteObject();
                    break;                    
                default:
                    break;
            }
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        UI(false);
    }

    private void ActivateItem()
    {
        values.Transparicy = values.Transparicy+trans_amount;
        this.gameObject.SetActive(false);
        
    }

    private void OpenDoor()
    {
        player.transform.position = point.transform.position;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == Var.PLAYER)
        {
            UI(true);
        } 
    }

    private void UI(bool status)
    {
        activated = status;

        if (type == 0 || type == 3)
        {
            showGrab.SetActive(status);
        }
        else if (type == 1)
        {
            showTeleport.SetActive(status);
        }
        else if (type == 2)
        {
            showDead.SetActive(status);
        }
    }

    void DeleteObject()
    {
        this.gameObject.SetActive(false);
        values.Transparicy = values.Transparicy + trans_amount;
        point.SetActive(false);
       
    }
}


