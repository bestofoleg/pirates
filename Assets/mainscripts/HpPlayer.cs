using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpPlayer : MonoBehaviour
{
    public GameObject hpb;
    public bool hld;
    public float timer;
    public bool healS;
    public Image hpp;
    public float hp;
    void Start()
    {
        hld = false;
        healS = false;
        hp = 1;
    }

   
    void Update()
    { if (hld == true) {

            hpb.SetActive(true);
         
        }
        timer -= Time.deltaTime * 2;
        
        if (hp > 1) {

            hp = 1;

        }
        if (healS == true) {
            
            hp += 0.3f;
            hld = false;
            hpb.SetActive(false);
        }
        if (timer <= 0) {

            timer = 0;
            healS = false;
        
        }

        hpp.fillAmount = hp;
    }

    public void HPtrue() {

        healS = true;
    
    }
}
