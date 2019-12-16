using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class load : MonoBehaviour
{
    public int sceneID;
    public Image loadIMG;
    void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    IEnumerator AsyncLoad() {

        AsyncOperation loading = SceneManager.LoadSceneAsync(sceneID);
        while (!loading.isDone)
        {
            float prog = loading.progress / 0.9f;
            loadIMG.fillAmount = loading.progress;
            yield return null;

        }
    }
}
