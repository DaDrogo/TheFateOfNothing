using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    private float Operation;

    public Slider slider;
    public int scene;

    private void LoadScene()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(scene);

        while (!async.isDone)
        {
            slider.value = Mathf.Clamp01(async.progress/0.9f);


            yield return null;
        }


        
    }
}
