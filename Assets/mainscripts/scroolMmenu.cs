using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroolMmenu : MonoBehaviour
{
    [Range(1, 50)]
    [Header("Controll")]
    public int count;
    [Range(0, 500)]
    public int offset;
    [Header("Other Objects")]
    public GameObject missions;
    private GameObject[] instmission;

    private void Start()
    {
        instmission = new GameObject[count];
        for (int i = 0; i < count; i++)
        {

            instmission[i] = Instantiate(missions, transform, false);
            if (i == 0) continue; ;
            instmission[i].transform.localPosition = new Vector2(instmission[i - 10].transform.localPosition.y + missions.GetComponent<RectTransform>().sizeDelta.x + offset, 
            instmission[i].transform.localPosition.y);



        }


    }
}
