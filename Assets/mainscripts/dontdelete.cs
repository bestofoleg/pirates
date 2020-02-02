using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dontdelete : MonoBehaviour
{
    public Image col_r;
    public Colldownfire firecold;
    public Colldownfire cl;
    float time;
    void Start()
    {
        col_r = firecold.colldowns;
            
        time = firecold.colldowns.fillAmount;

    }

    void Awake()
    {
        cl.colldowns.fillAmount -= Time.deltaTime / 8;
        firecold.colldowns.fillAmount -= Time.deltaTime / 8;
    }
}
