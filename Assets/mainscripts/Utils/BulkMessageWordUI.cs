using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulkMessageWordUI : MonoBehaviour
{
    public Text text;

    public float bulkSpeed;
    
    public int maxLifeTime;

    private Transform begain;
    
    private int lifeTime;

    private bool started = false;

    private void Awake()
    {
        lifeTime = 0;
    }

    private void Update()
    {
        if (started)
        {
            lifeTime++;
            if (lifeTime < maxLifeTime)
            {
                text.rectTransform.position += text.rectTransform.up * Time.deltaTime * bulkSpeed;
            }
            else
            {
                GameObject.Destroy(this.gameObject);
            }
        }
    }

    public void StartBulk(Transform targetGameObjectTransformFrom)
    {
        begain = targetGameObjectTransformFrom;
        this.text.rectTransform.position = Camera.main.WorldToScreenPoint(begain.position);
        started = true;
    }
}
