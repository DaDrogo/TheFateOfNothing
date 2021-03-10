using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterValues:MonoBehaviour
{
    public float Transparicy;
    public float MoveSpeed;
    public float JumpHight;

    SpriteRenderer sprite;
    GameManage manage;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Transparicy <= 0)
        {
            Transparicy = 100;
            manage.PlayDead();
        }
        else if (Transparicy >= 100)
        {
            Transparicy = 100;
        }
        sprite = GetComponent<SpriteRenderer>();
        Color tmp = sprite.color;
        tmp.a = Transparicy*0.01f;
        sprite.GetComponent<SpriteRenderer>().color = tmp;
    }

}
