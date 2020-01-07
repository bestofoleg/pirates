using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class load : MonoBehaviour
{
    public DontDestroylvl lvls;
    public int sceneID;
    public Image loadIMG;
    void Start()
    {
        sceneID = lvls.lvl;
        StartCoroutine(AsyncLoad());
    }

    void Update ()
    {
        
    }
    IEnumerator AsyncLoad()
    {
       
     
        AsyncOperation loading = SceneManager.LoadSceneAsync(sceneID);
       if (sceneID <= 0)
        {
            sceneID = 1;
        }
        if (sceneID == 1)


        {
            while (!loading.isDone)

            {
                float prog = loading.progress / 0.9f;
                loadIMG.fillAmount = loading.progress;
                yield return null;

            }
        }
            if (sceneID == 2)
            {
                float prog = loading.progress / 0.9f;
                loadIMG.fillAmount = loading.progress;
                yield return null;
            }
        
    }
}
