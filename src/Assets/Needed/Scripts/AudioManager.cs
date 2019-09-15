using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using Random = UnityEngine.Random;

public class AudioManager : MonoBehaviour
{
    public Sounds[] Clips;

    public Sounds[] Themes;

    bool musik = true;

    int track;

    public int type;

    private void Awake()
    {
        if (type == 0)
        {
            foreach (Sounds s in Themes)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = 0.5f;
                s.source.pitch = 0.5f;
            }
            track = Random.Range(0, Themes.Length - 1);
            
            StartCoroutine(playTheme(track.ToString()));
        }
        if (type == 1)
        {
            foreach (Sounds s in Clips)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = 0.6f;
                s.source.pitch = 0.5f;
                s.source.loop = s.loop;
            }
            
        }
    }

    public void Play(string name,int play)
    {
       Sounds s = Array.Find(Clips, sound => sound.name == name);
        if (s != null) {
            if (play == 1)
            {
                s.source.Stop();
                s.source.loop = false;
                
            }
            else if (s.source.isPlaying == false)
            {

                if (play == 0)
                {
                    s.source.Play();
                    
                }
                if (play == 2)
                {
                    //water
                    s.source.volume = Random.Range(0.1f, 0.2f);
                    s.source.pitch = Random.Range(1.6f, 2f);

                    s.source.Play();
                    
                }
                if (play == 3)
                {
                    //wood gras
                    s.source.volume = Random.Range(0.1f, 0.3f);
                    s.source.pitch = Random.Range(1f, 1.4f);

                    s.source.Play();
                    
                }
                if (play == 4)
                {
                    //gravel
                    s.source.volume = Random.Range(0.1f, 0.3f);
                    s.source.pitch = Random.Range(0.6f, 1f);

                    s.source.Play();
                    
                }
            }
        }
    }

   IEnumerator playTheme(string name)
   {
       Sounds s = Array.Find(Themes, sound => sound.name == name);
       s.source.Play();
       yield return new WaitForSeconds(s.clip.length);
       track = Random.Range(0, Themes.Length - 1);      
       StartCoroutine(playTheme(track.ToString()));
    }

}
