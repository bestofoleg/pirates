using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroylvl : MonoBehaviour
{
    load lol;

    public int lvl;
    
    void Start()
    {  
   
    }
    public void SceneIDcave()
    {
        
        DontDestroyOnLoad(this.gameObject);
        lvl = 2;
        SceneManager.LoadScene(2);
       

    }

    public void scenebattle()
    {

        DontDestroyOnLoad(this.gameObject);
        lvl = 3;
        SceneManager.LoadScene(3);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
