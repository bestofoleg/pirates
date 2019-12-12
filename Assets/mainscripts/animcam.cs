using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcam : MonoBehaviour
{
    public AnimationClip walk;
    Animation anim;
    public GameObject cam;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        anim.clip = walk;
        anim.Play();
    }
}
