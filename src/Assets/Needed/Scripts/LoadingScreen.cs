using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    float operation;
    public Slider slider;

    public void LoadScene()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(2);

        while (!async.isDone)
        {
            slider.value = Mathf.Clamp01(async.progress/0.9f);


            yield return null;
        }


        
    }
}
