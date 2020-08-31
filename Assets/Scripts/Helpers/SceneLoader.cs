using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private bool loadScene = false;

    [SerializeField]
    private int scene;


    void Awake()
    {
        StartCoroutine(LoadNewScene());
    }


    IEnumerator LoadNewScene()
    {
        //Just to show the loading screen
        yield return new WaitForSeconds(3);

        AsyncOperation async = SceneManager.LoadSceneAsync(scene);

        while (!async.isDone)
        {
            yield return null;
        }

    }
}
