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


    private void OnTriggerExit2D(Collider2D other)
    {
        if (type == 0||type==3)
        {
            showGrab.SetActive(false);
        }
        else if (type == 1)
        {
            showTeleport.SetActive(false);
        }
        else if (type == 2)
        {
            showDead.SetActive(false);
        }

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

        if (other)
        {
            if (type == 0)
            {
                showGrab.SetActive(true);
                if (Input.GetButtonDown("E"))
                {
                    ActivateItem();
                    showGrab.SetActive(false);
                }
            }
            else if (type == 1)
            {
                showTeleport.SetActive(true);
                if (Input.GetButtonDown("E"))
                {
                    OpenDoor();
                    showTeleport.SetActive(false);
                }
            }
            else if (type == 2)
            {
                showDead.SetActive(true);
                if (Input.GetButtonDown("E"))
                {
                    manager.ResetGame();
                    showDead.SetActive(false);
                }
            }
            else if(type == 3)
            {
                showGrab.SetActive(true);
                if (Input.GetButtonDown("E"))
                {
                    DeleteObject();
                    showGrab.SetActive(false);
                }
            }

        }
        
    }
    void DeleteObject()
    {
        this.gameObject.SetActive(false);
        values.Transparicy = values.Transparicy + trans_amount;
        point.SetActive(false);
       
    }
}


