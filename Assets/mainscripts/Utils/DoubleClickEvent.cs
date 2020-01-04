using System;
using UnityEngine;

public class DoubleClickEvent : MonoBehaviour
{
    public float delta = 0.2f;
    
    public delegate void DoubleClick();
    
    public event DoubleClick doubleClickEvent;
    
    private void Awake()
    {
    }

    private void Update()
    {
    }
}