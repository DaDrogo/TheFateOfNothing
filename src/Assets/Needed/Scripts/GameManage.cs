using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{


    public GameObject player;

    public GameObject startPoint;
    public GameObject endPoint;

    public CharacterValues values;

    public GameObject reOB;

    public AudioManager audioM;

    public float startTransparicy;
    

    private void Start()
    {
        StartGame();
    }

    public void ResetGame()
    {

        ResetOb();
        ResetMusik();
        //tp back zo start
        //reset transparent
        //active alle vergessen und erkenntnis
        StartGame();
    }

    public void StartGame()
    {
        player.transform.position = startPoint.transform.position;
        values.Transparicy = startTransparicy;
    }

    public void PlayDead()
    {
        
        player.transform.position = endPoint.transform.position;
        
    }



    public void ResetOb()
    {
        for(int a = 0; a < transform.childCount; a++)
        {
            transform.GetChild(a).gameObject.SetActive(true);
        }
    }

    public void ResetMusik()
    {
        audioM.Play("Garten-Nacht", 1);
        audioM.Play("Nacht-Regen", 1);
        audioM.Play("Wind_Flach", 1);
        audioM.Play("Feld", 1);
        audioM.Play("Meer", 1);
        audioM.Play("Wind-Berg", 1);
        audioM.Play("Wind-Flach", 1);
        audioM.Play("Office", 1);
        audioM.Play("Street", 1);
        audioM.Play("War", 1);
    }
}
