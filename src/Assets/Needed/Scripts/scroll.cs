using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public MeshRenderer meshR;

    [Space(3)]
    public float speed;

    public int type;
    private void Update()
    {
        if (type == 0)
        {
            meshR.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
        }
        else if (type == 1)
        {
            meshR.material.mainTextureOffset += new Vector2(speed *2* Time.deltaTime, speed * Time.deltaTime);
        }
    }
}
