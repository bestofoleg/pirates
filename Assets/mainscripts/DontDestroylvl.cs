using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroylvl : MonoBehaviour
{

    public int lvl;
    
    void Start()
    {  
    DontDestroyOnLoad(this.gameObject);
    }
    public void SceneIDcave()
    {
        lvl = 2;
        SceneManager.LoadScene("load");
        

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
