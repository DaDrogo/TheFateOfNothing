using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sounds
{
    public AudioClip clip;

    public string name;

    [Range(0, 1f)]
    public float volume=0.6f;
    [Range(0f,3f)]
    public float pitch = 0.5f;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
